using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database;
using artifact_manager2.Database.Models;
using artifact_manager2.Database.Context;
using artifact_manager2.Controllers;

namespace artifact_manager2
{
    /// App responsible for managing database and app at the beginning of the app session
    public class AppStart
    {
        public static void verifyDatabase()
        {
            createDatabaseIfNeeeded();
            if (!isAdminInDatabase())
            {
                addDefaultAdmin();
            }
            if (!ClassController.isCharacterBaseClassAdded())
            {
                ClassController.addCharacterBaseClass();
            }
        }

        private static void createDatabaseIfNeeeded()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Database.EnsureCreated();
            }
        }
        private static bool isAdminInDatabase()
        {
            var dbContext = new ApplicationDbContext();
            using (dbContext)
            {
                var allUsers = dbContext.Users.ToList();
                var admins = (
                    from user in dbContext.Users
                    join userrole in dbContext.UserRoles on user.UserId equals userrole.UserId
                    join role in dbContext.Roles on userrole.RoleId equals  role.RoleId
                    where role.IsAdmin == true
                    select new { user }
                ).ToList();
               
                return admins.Count > 0;
            }
        }

        private static void addDefaultAdmin()
        {
            Role adminRole = new Role();
            adminRole.Name = "basic_admin";
            adminRole.IsAdmin = true;
            adminRole.CanDeleteRecords = false;
            adminRole.CanUpdateRecords = false;
            adminRole.CanAddRecords = false;
            adminRole.CanDeleteClasses = false;
            adminRole.CanUpdateClasses = false;
            adminRole.CanAddClasses = false;

            LoginController.addRole(adminRole);
            

            User admin = new User();
            admin.UserName = "admin";
            admin.Password = "admin";

            LoginController.addUser(admin);

            

            Role retievedRole = LoginController.getRole("basic_admin");
            User retievedUser = LoginController.getUser("admin");

            UserRole userRole = new UserRole();
            userRole.RoleId = retievedRole.RoleId;
            userRole.UserId = retievedUser.UserId;
            LoginController.addUserRole(userRole);
        }
    }
}
