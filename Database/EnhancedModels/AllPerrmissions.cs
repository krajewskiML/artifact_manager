using artifact_manager2.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artifact_manager2.Database.EnhancedModels
{
    public class AllPerrmissions
    {
        public AllPerrmissions(List<Role> roles)
        {
            this.IsAdmin = false;
            this.CanDeleteClasses = false;
            this.CanDeleteRecords = false;
            this.CanUpdateClasses = false;
            this.CanUpdateRecords = false;
            this.CanAddClasses = false;
            this.CanAddRecords = false;
            foreach(Role role in roles)
            {
                if(role.IsAdmin) this.IsAdmin = true;
                if(role.CanDeleteClasses) this.CanDeleteClasses = true;
                if(role.CanUpdateClasses) this.CanUpdateClasses = true;
                if(role.CanAddClasses) this.CanAddClasses = true;
                if(role.CanDeleteRecords) this.CanDeleteRecords = true;
                if(role.CanUpdateRecords) this.CanUpdateRecords = true;
                if(role.CanAddRecords) this.CanAddRecords = true;
            }
        }
        public bool IsAdmin { get; set; }
        public bool CanAddClasses { get; set; }
        public bool CanUpdateClasses { get; set; }
        public bool CanDeleteClasses { get; set; }
        public bool CanAddRecords { get; set; }
        public bool CanUpdateRecords { get; set; }
        public bool CanDeleteRecords { get; set; }
    }
}
