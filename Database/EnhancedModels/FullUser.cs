using artifact_manager2.Database.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace artifact_manager2.Database.EnhancedModels
{
    public class FullUser
    {
        public FullUser(User user, List<Role> roles)
        {
            allPerrmissions = new AllPerrmissions(roles);
            UserId = user.UserId;
            UserName = user.UserName;
            Password = user.Password;
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public AllPerrmissions allPerrmissions { get; set; }

        public bool IsAdmin()
        {
            return allPerrmissions.IsAdmin;
        }
    }
}
