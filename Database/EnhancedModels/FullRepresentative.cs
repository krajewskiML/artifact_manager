using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database.Models;
using artifact_manager2.Controllers;
using Attribute = artifact_manager2.Database.Models.Attribute;

namespace artifact_manager2.Database.EnhancedModels
{
    public class FullRepresentative
    {
        private Dictionary<string, string> properties;

        public int representaiveId;

        public string className;

        private List<Attribute> attributes;
        public FullRepresentative(Representative basicRepresentative)
        {
            className = ClassController.getClassName(basicRepresentative.CategoryId);
            representaiveId = basicRepresentative.RepresentativeId;
            properties = EntityController.getEntityProperties(basicRepresentative.RepresentativeId);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(className);
            stringBuilder.Append(": ");
            foreach (var property in properties)
            {
                stringBuilder.Append(property.Key);
                stringBuilder.Append(": ");
                stringBuilder.Append(property.Value);
                stringBuilder.Append("; ");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }

        public int getStrength()
        {
            return int.Parse(properties["Strength"]);
        }

        public string toShowOnBoard()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(properties[ClassController.CHARACTER_BASE_CLASS_NAME]);
            stringBuilder.Append(": Strenght = ");
            stringBuilder.Append(properties[ClassController.CHARACTER_BASE_CLASS_STRENGTH]);
            return stringBuilder.ToString();
            // show name + strength (all characters have defined name and strngth in base class)
        }

        public DateTime getDateOfChange()
        {
            var repr = EntityController.GetRepresentative(representaiveId);
            return Convert.ToDateTime(repr.DateModified2);

        }
    }
}
