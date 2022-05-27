using artifact_manager2.Database.Models;
using System.Collections.Generic;
namespace artifact_manager2.Database.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public int? SuperClassId { get; set; }

        public string Name { get; set; }

        public ICollection<Attribute> Attributes { get; set; }

        public ICollection<Representative> Representatives { get; set; }

        public Category SuperClassCategory { get; set; }

    }
}