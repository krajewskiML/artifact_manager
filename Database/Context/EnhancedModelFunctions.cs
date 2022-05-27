using Microsoft.EntityFrameworkCore;
using artifact_manager2.Database.Models;
using artifact_manager2.Database.Models;
using Attribute = artifact_manager2.Database.Models.Attribute;
using System.Linq;
using artifact_manager2.Database.EnhancedModels;
using artifact_manager2.Database;

namespace artifact_manager2.Database.Context
{
    public partial class ApplicationDbContext
    {
        public FullUser RetrieveUser(string username)
        {
            var user = Users.Where(u => u.UserName == username).FirstOrDefault();
            var roles = (
                from r in Roles
                join ur in UserRoles on r.RoleId equals ur.RoleId
                where ur.UserId ==user.UserId
                select r).ToList();
            return new FullUser(user, roles);
        }
    }
}

