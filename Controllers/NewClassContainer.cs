using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attribute = artifact_manager2.Database.Models.Attribute;

namespace artifact_manager2.Controllers
{
    internal class NewClassContainer
    {
        public int? SuperClassId { get; set; }

        public string Name { get; set; }

        public List<Attribute> SuperClassAttributes { get; set; }

        public List<Attribute> newAttributes { get; set; }
        public NewClassContainer()
        {
            newAttributes = new List<Attribute>();
            SuperClassAttributes = new List<Attribute>();
        }

        public bool isNameValid(string attributeName)
        {
            if (newAttributes.Select(a => a.Name).Contains(attributeName) || SuperClassAttributes.Select(a => a.Name).Contains(attributeName))
            {
                return false;
            }
            return true;
        }

        public void addAttribute(string attributeName, string attributeType)
        {
            newAttributes.Add(new Attribute() { Name = attributeName, TypeOfAttribute = attributeType });
        }


        public void deleteAttribute(string attributeName)
        {
            newAttributes.RemoveAll(a => a.Name == attributeName);
        }

        public void setSuperClassAttributes(int? superClassId, List<Attribute> attributes)
        {
            SuperClassId = superClassId;
            SuperClassAttributes = attributes;
        }

        public void setName(string name)
        {
            Name = name;
        }
    }
}
