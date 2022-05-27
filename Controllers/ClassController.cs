using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database.Models;
using artifact_manager2.Database.Context;
using Attribute = artifact_manager2.Database.Models.Attribute;

namespace artifact_manager2.Controllers
{
    internal class ClassController
    {
        private const string NONE_BASE_CLASS = "None";
        public const string CHARACTER_BASE_CLASS = "Character";
        public const string CHARACTER_BASE_CLASS_NAME = "Name";
        public const string CHARACTER_BASE_CLASS_STRENGTH = "Strength";

        public static bool isCharacterBaseClassAdded()
        {
            return isClassNameTaken(CHARACTER_BASE_CLASS);
        }

        public static void addCharacterBaseClass()
        {
            NewClassContainer characterClass = new NewClassContainer();
            characterClass.Name = CHARACTER_BASE_CLASS;
            List<Attribute> attributes = new List<Attribute>();
            characterClass.setSuperClassAttributes(null, attributes);
            characterClass.addAttribute(CHARACTER_BASE_CLASS_NAME, "String");
            characterClass.addAttribute(CHARACTER_BASE_CLASS_STRENGTH, "Integer");
            addClass(characterClass);
        }
        public static List<string> getClassesName() { 
            using(var dbContext = new ApplicationDbContext())
            {
                return dbContext.Categories.Select(c => c.Name).ToList();
            }
        }

        public static List<Attribute> getClassesDescription(int classId)
        {
            var className = getClassName(classId);
            return getClassesDescription(className);
        }

        public static List<Attribute> getClassesDescription(string classname)
        {
            if (classname == NONE_BASE_CLASS)
            {
                return new List<Attribute>();
            }
            List<Attribute> attributes = new List<Attribute>();
            using (var dbContext = new ApplicationDbContext())
            {
                Category category = dbContext.Categories.Where(c => c.Name == classname).FirstOrDefault();
                if (category.SuperClassId != null)
                {
                    Category superCategory = dbContext.Categories.Where(c => c.CategoryId == category.SuperClassId).FirstOrDefault();
                    attributes.AddRange(getClassesDescription(superCategory.Name));
                }
                var classnamesAttributes = (
                    from a in dbContext.Attributes
                    join ca in dbContext.CategoryAttributes on a.AttributeId equals ca.AttributeId
                    where ca.CategoryId == category.CategoryId
                    select a
                    ).ToList();
                attributes.AddRange(classnamesAttributes);
            }
            return attributes;
        }

        public static List<Attribute> getSpecificClassesDescription(string classname)
        {
            if (classname == NONE_BASE_CLASS)
            {
                return new List<Attribute>();
            }
            List<Attribute> attributes = new List<Attribute>();
            using (var dbContext = new ApplicationDbContext())
            {
                Category category = dbContext.Categories.Where(c => c.Name == classname).FirstOrDefault();
                var classnamesAttributes = (
                    from a in dbContext.Attributes
                    join ca in dbContext.CategoryAttributes on a.AttributeId equals ca.AttributeId
                    where ca.CategoryId == category.CategoryId
                    select a
                    ).ToList();
                attributes.AddRange(classnamesAttributes);
            }
            return attributes;
        }



        public static string AttributeToString(Attribute attr)
        {
            var sb = new StringBuilder();
            sb.Append(attr.Name);
            sb.Append('\t');
            sb.Append(attr.TypeOfAttribute);
            return sb.ToString();
        }

        public static int? getClassId(string classname)
        {
            if(classname == NONE_BASE_CLASS)
            {
                return null;
            }
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Categories.Where((c) => c.Name == classname).Select(c => c.CategoryId).FirstOrDefault();
            }
        }

        public static bool isClassNameTaken(string classname)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                return dbContext.Categories.Where(c => c.Name == classname).Any();
            }
        }

        public static void addClass(NewClassContainer newClass)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                Category newCategory = new Category() { SuperClassId = newClass.SuperClassId, Name = newClass.Name };
                dbContext.Categories.Add(newCategory);
                foreach(var attr in newClass.newAttributes)
                {
                    dbContext.Attributes.Add(attr);
                }
                foreach (var attr in newClass.newAttributes)
                {
                    CategoryAttribute cr = new CategoryAttribute()
                    {Attribute = attr, Category=newCategory};
                    dbContext.CategoryAttributes.Add(cr);
                }
                dbContext.SaveChanges();
            }

        }

        public static Category GetCategory(string classname)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                return dbContext.Categories.Where(c =>c.Name == classname).FirstOrDefault();
            }
        }

        public static void deleteClass(string classname)
        {
            using(var dbContext =new ApplicationDbContext())
            {
                Category category = GetCategory(classname);
                var subclasses = dbContext.Categories
                    .Where(c => c.SuperClassId == category.CategoryId)
                    .Select(c => c.Name).ToList();
                foreach (var subclass in subclasses)
                {
                    deleteClass(subclass);
                }
                deleteMembers(classname);

                var attributeConnectors = dbContext.CategoryAttributes.Where(ca => ca.CategoryId == category.CategoryId).Select(ca => ca.AttributeId).ToList();
                var attributes = dbContext.Attributes.Where(a => attributeConnectors.Contains(a.AttributeId)).ToList();
                dbContext.Attributes.RemoveRange(attributes);
                var attributeConnectorsFull = dbContext.CategoryAttributes.Where(ca => ca.CategoryId == category.CategoryId).ToList();
                dbContext.CategoryAttributes.RemoveRange(attributeConnectorsFull);
                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
            }
        }

        public static void deleteMembers(string classname)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var category = GetCategory(classname);
                var members = dbContext.Representatives.Where(r => r.CategoryId == category.CategoryId).Select(r => r.RepresentativeId);
                var stringValues = dbContext.StringValues.Where(s => members.Contains(s.RepresentativeId));
                var floatValues = dbContext.FloatValuess.Where(s => members.Contains(s.RepresentativeId));
                var intValues = dbContext.IntegerValues.Where(s => members.Contains(s.RepresentativeId));

                dbContext.StringValues.RemoveRange(stringValues);
                dbContext.FloatValuess.RemoveRange(floatValues);
                dbContext.IntegerValues.RemoveRange(intValues);

                var fullMembers = dbContext.Representatives.Where(r => r.CategoryId == category.CategoryId);
                dbContext.Representatives.RemoveRange(fullMembers);
                dbContext.SaveChanges();
            }
        }

        public static string getClassName(int classId)
        {
            using(var dbContext =new ApplicationDbContext())
            {
                return dbContext.Categories.Where(c => c.CategoryId == classId).Select(c => c.Name).First();
            }
        }

        public static void removeAttribute(string className, string attributeName)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var category = GetCategory(className);
                var attrIds = dbContext.Attributes.Where(a => a.Name == attributeName).Select(a => a.AttributeId).ToList();
                var catattr = dbContext.CategoryAttributes
                    .Where(ca => ca.CategoryId == category.CategoryId && attrIds.Contains(ca.AttributeId))
                    .Select(ca => ca.AttributeId).First();
                var attr = dbContext.Attributes.Where(a => a.AttributeId == catattr).FirstOrDefault();
                var connection = dbContext.CategoryAttributes
                    .Where(ca => ca.AttributeId == attr.AttributeId && ca.CategoryId == category.CategoryId)
                    .FirstOrDefault();
                dbContext.CategoryAttributes.Remove(connection);
                dbContext.Attributes.Remove(attr);
                dbContext.SaveChanges();
            }
        }

        public static void renameAttribute(string className, string oldAttributeName, string newAttributeName)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var category = GetCategory(className);
                var attrIds = dbContext.Attributes.Where(a => a.Name == oldAttributeName).Select(a => a.AttributeId).ToList();
                var catattr = dbContext.CategoryAttributes
                    .Where(ca => ca.CategoryId == category.CategoryId && attrIds.Contains(ca.AttributeId))
                    .Select(ca => ca.AttributeId).First();
                var attrToChange = dbContext.Attributes.Where(ca => ca.AttributeId == catattr).First();
                attrToChange.Name = newAttributeName;
                dbContext.SaveChanges();
            }
        }

        private static void addAttribute(Attribute attr)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Attributes.Add(attr);
                dbContext.SaveChanges();
            }
        }


        public static void addAttributeToClass(string className, string attrname, string pickedType, string defaultValue)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                var pickedClass = GetCategory(className);
                var attribute = new Attribute() { Name = attrname, TypeOfAttribute = pickedType };
                addAttribute(attribute);
                var addedAttribute = dbContext.Attributes.Where(a => a.Name == attrname && a.TypeOfAttribute == pickedType).First();
                CategoryAttribute connection = new CategoryAttribute() { CategoryId = pickedClass.CategoryId, AttributeId = addedAttribute.AttributeId};
                dbContext.CategoryAttributes.Add(connection);
                var allrepresentants = EntityController.GetFullRepresentatives(className);
                var allRepresentantsId = from representant in allrepresentants select representant.representaiveId;
                foreach(var id in allRepresentantsId)
                {
                    if (pickedType == "Integer")
                    {
                        dbContext.IntegerValues.Add(
                            new IntegerValue() {
                                AttributeId = addedAttribute.AttributeId,
                                RepresentativeId = id,
                                Value = int.Parse(defaultValue),
                            }
                        );
                    }
                    if (pickedType == "Float")
                    {
                        dbContext.FloatValuess.Add(
                            new FloatValue()
                            {
                                AttributeId = addedAttribute.AttributeId,
                                RepresentativeId = id,
                                Value = float.Parse(defaultValue),
                            }
                        );
                    }
                    if (pickedType == "String")
                    {
                        dbContext.StringValues.Add(
                            new StringValue()
                            {
                                AttributeId = addedAttribute.AttributeId,
                                RepresentativeId = id,
                                Value = defaultValue,
                            }
                        );
                    }
                }
                dbContext.SaveChanges();
            }
        }
        
    }
}
