using artifact_manager2.Database.Models;

namespace artifact_manager2.Database.Models
{
    public class IntegerValue
    {
        public int RepresentativeId { get; set; }

        public int AttributeId { get; set; }

        public int Value { get; set; }
        public Representative representative { get; set; }

        public Attribute attribute { get; set; }
    }
}