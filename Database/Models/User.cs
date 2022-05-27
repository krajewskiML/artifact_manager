using artifact_manager2.Database.Models;
using System.Collections.Generic;

namespace artifact_manager2.Database.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public ICollection<UserRole> userRoles { get; set; }
    }
}
