using artifact_manager2.Database.Models;

namespace artifact_manager2.Database.Models
{
    public class StringValue
    {
        public int RepresentativeId { get; set; }

        public int AttributeId { get; set; }

        public string Value { get; set; }

        public Representative representative { get; set; }

        public Attribute attribute { get; set; }
    }
}