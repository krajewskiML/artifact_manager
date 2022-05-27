using artifact_manager2.Database.Models;
using System.Collections.Generic;

namespace artifact_manager2.Database.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public bool IsAdmin { get; set; }
        public bool CanAddClasses { get; set; }
        public bool CanUpdateClasses { get; set; }
        public bool CanDeleteClasses { get; set; }
        public bool CanAddRecords { get; set; }
        public bool CanUpdateRecords { get; set; }
        public bool CanDeleteRecords { get; set; }

        public  ICollection<UserRole> userRoles { get; set; }
    }
}
