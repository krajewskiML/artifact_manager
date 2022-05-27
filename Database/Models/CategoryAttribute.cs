using artifact_manager2.Database.Models;

namespace artifact_manager2.Database.Models
{
    public class CategoryAttribute
    {
        public int CategoryId { get; set; }

        public int AttributeId { get; set; }

        public Category Category { get; set; }

        public Attribute Attribute { get; set; }
    }
}