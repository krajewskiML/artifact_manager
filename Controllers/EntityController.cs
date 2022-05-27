using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database.Context;
using artifact_manager2.Database.EnhancedModels;
using artifact_manager2.Database.Models;
using Microsoft.EntityFrameworkCore;
using Attribute = artifact_manager2.Database.Models.Attribute;

namespace artifact_manager2.Controllers
{
    internal class EntityController
    {
        private static void addRepresentant(Representative representative)
        {
            using(var dbContext = new ApplicationDbContext()) {
                dbContext.Representatives.Add(representative);
                dbContext.SaveChanges();
            }
        }

        public static Representative GetRepresentative(int reprId)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Representatives.Where(r => r.RepresentativeId == reprId).First();
            }
        }

        private static int getLatestRepresentativeId()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var representative = dbContext.Representatives.ToList();
                var dates = new List<DateTime>();
                foreach (var rep in representative)
                {
                    dates.Add(Convert.ToDateTime(rep.DateModified2));

                }
                var maxDate = dates.Max();
                var maxDateIndex = dates.FindIndex(date => date == maxDate);
                return representative[maxDateIndex].RepresentativeId;
            }

        }
        public static void AddRecord(string classname, Dictionary<string, string> properties)
        {
            Category category = ClassController.GetCategory(classname);
            Representative representative = new Representative() 
            { CategoryId = category.CategoryId, DateModified2 = DateTime.Now.ToString() };

            addRepresentant(representative);

            var indexedRepresentative = getLatestRepresentativeId();
            var categoriesProperties = ClassController.getClassesDescription(classname);

            using (var dbContext = new ApplicationDbContext())
            {
                foreach (var attr in categoriesProperties)
                {
                    var uncasted_value = properties[attr.Name];
                    switch (attr.TypeOfAttribute)
                    {
                        case "Float":
                            FloatValue floatValue = new FloatValue()
                            {
                                Value = float.Parse(uncasted_value),
                                AttributeId = attr.AttributeId,
                                RepresentativeId = indexedRepresentative,
                                /*representative = representative,
                                attribute = attr,*/
                            };
                            dbContext.FloatValuess.Add(floatValue);
                            break;
                        case "Integer":
                            IntegerValue integerValue = new IntegerValue()
                            {
                                Value = int.Parse(uncasted_value),
                                AttributeId = attr.AttributeId,
                                RepresentativeId = indexedRepresentative,
                                /*representative = representative,
                                attribute = attr,*/
                            };
 
                            dbContext.IntegerValues.Add(integerValue);
                            break;
                        case "String":
                            StringValue stringValue = new StringValue()
                            {
                                Value = uncasted_value,
                                AttributeId = attr.AttributeId,
                                RepresentativeId = indexedRepresentative,
                                /*representative = representative,
                                attribute = attr,*/
                            };
                            dbContext.StringValues.Add(stringValue);
                            break;
                    }
                    //TODO: fix this (it wants to add attributes while i dont wantto)
                }
                dbContext.SaveChanges();
            }
        }

        public static int getEntityClass(int entityId)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Representatives.Where(r => r.RepresentativeId == entityId).Select(r => r.CategoryId).First();
            }
        }

        public static Dictionary<string, string> getEntityProperties(int entityId)
        {
            var classId = getEntityClass(entityId);
            var attributes = ClassController.getClassesDescription(classId);
            var attributeIds = from attr in attributes select attr.AttributeId;

            var properties = new Dictionary<string, string>();
            
            using(var dbContext = new ApplicationDbContext())
            {
                foreach(Attribute attribute in attributes)
                {
                    var attribName = attribute.Name;
                    switch (attribute.TypeOfAttribute)
                    {
                        case "Float":
                            var attribValueFloat = 
                                dbContext.FloatValuess
                                .Where(val => val.AttributeId == attribute.AttributeId && val.RepresentativeId == entityId)
                                .Select(val => val.Value)
                                .First();
                            properties.Add(attribName, attribValueFloat.ToString());
                            break;
                        case "Integer":
                            var attribValueInt =
                                dbContext.IntegerValues
                                .Where(val => val.AttributeId == attribute.AttributeId && val.RepresentativeId == entityId)
                                .Select(val => val.Value)
                                .First();
                            properties.Add(attribName, attribValueInt.ToString());
                            break;
                        case "String":
                            var attribValueString =
                                dbContext.StringValues
                                .Where(val => val.AttributeId == attribute.AttributeId && val.RepresentativeId == entityId)
                                .Select(val => val.Value)
                                .First();
                            properties.Add(attribName, attribValueString.ToString());
                            break;
                    }
                   
                }

                return properties;
            }
        }

        private static List<int> allSubCategories(int classId)
        {
            var list = new List<int>();
            list.Add(classId);
            using (var dbContext = new ApplicationDbContext())
            {
                var thisClassSubClasses = dbContext.Categories.Where(c => c.SuperClassId == classId).ToList();
                if (list.Count > 0)
                {
                    foreach (var subCategory in thisClassSubClasses)
                    {
                        list.Add(subCategory.CategoryId);
                    }
                }
                else
                {
                    return list;
                }
            }
            return list;
        }

        public static List<FullRepresentative> GetFullRepresentatives(string classname)
        {
            var classid = ClassController.getClassId(classname);
            var dependingClasses = allSubCategories((int)classid);
            using (var dbContext = new ApplicationDbContext())
            {
               var entitites = 
                    from rep in dbContext.Representatives
                    where dependingClasses.Contains(rep.CategoryId)
                    select rep;

                List<FullRepresentative> allEntities = new List<FullRepresentative>();
                foreach (var ent in entitites)
                {
                    allEntities.Add(new FullRepresentative(ent));
                }
                return allEntities;
            }
        }

        public static List<FullRepresentative> GetStrongestRepresentatives()
        {
            var characters = GetFullRepresentatives(ClassController.CHARACTER_BASE_CLASS);
            var top5 = characters.OrderByDescending(c => c.getStrength()).ToList();
            if(top5.Count > 5)
            {
                return top5.Take(5).ToList();
            }
            else
            {
                return top5;
            }
        }

        public static List<FullRepresentative> GetLatestRepresetatives()
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var characters = dbContext.Representatives.ToList();
                var fullCharacters = new List<FullRepresentative>();
                foreach (Representative rep in characters)
                {
                    fullCharacters.Add(new FullRepresentative(rep));
                }
                var top5 = fullCharacters.OrderByDescending(c => c.getDateOfChange()).ToList();
                if (top5.Count > 5)
                {
                    return top5.Take(5).ToList();
                }
                else
                {
                    return top5;
                }
            }
            
        }

        public static void deleteEntity(FullRepresentative rep)
        {
            if (rep == null)
            {
                return;
            }
            var representantId = rep.representaiveId;

            using (var dbContext = new ApplicationDbContext())
            {
                var floatValues = dbContext.FloatValuess.Where(fv => fv.RepresentativeId == representantId).ToList();
                var stringValues = dbContext.StringValues.Where(fv => fv.RepresentativeId == representantId).ToList();
                var intValues = dbContext.IntegerValues.Where(fv => fv.RepresentativeId == representantId).ToList();

                var repr = dbContext.Representatives.Where(f => f.RepresentativeId == representantId).ToList();

                dbContext.FloatValuess.RemoveRange(floatValues);
                dbContext.StringValues.RemoveRange(stringValues);
                dbContext.IntegerValues.RemoveRange(intValues);
                dbContext.Representatives.RemoveRange(repr);

                dbContext.SaveChanges();
            }
        }
    }
}
