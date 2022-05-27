using artifact_manager2.Database.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace artifact_manager2.Database.Models
{
    public class Representative
    {
        public int RepresentativeId { get; set; }

        public int CategoryId { get; set; }

        public string DateModified2 { get; set; }

    }
}