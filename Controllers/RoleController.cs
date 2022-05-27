using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database.Context;
using artifact_manager2.Database.Models;

namespace artifact_manager2.Controllers
{
    public static class RoleController
    {
        public static List<Role> getAllRoles()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Roles.ToList();
            }
        }

        public static bool checkIfRoleExists(string roleName)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var role =  dbContext.Roles.Where(r => r.Name == roleName).FirstOrDefault();
                return role != null;
            }
        }

        public static void addRole(string roleName, Dictionary<string, bool> permissions)
        {
            Role role = new Role();
            role.Name = roleName;
            role.IsAdmin = permissions["IsAdmin"];
            role.CanAddClasses = permissions["CanAddClasses"];
            role.CanUpdateClasses = permissions["CanUpdateClasses"];
            role.CanDeleteClasses = permissions["CanDeleteClasses"];
            role.CanAddRecords = permissions["CanAddRecords"];
            role.CanUpdateRecords = permissions["CanUpdateRecords"];
            role.CanDeleteRecords = permissions["CanDeleteRecords"];

            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Roles.Add(role);
                dbContext.SaveChanges();
            }
        }

        public static void deleteRole(string rolename)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var roleToDelete = dbContext.Roles.Where((r) => r.Name == rolename).FirstOrDefault();
                var usersToDelete = (
                    from u in dbContext.Users
                    join ur in dbContext.UserRoles on u.UserId equals ur.UserId
                    where ur.RoleId == roleToDelete.RoleId
                    select u).ToList();
                var idOfUsersToDelete = new List<int>();
                foreach (var user in usersToDelete)
                {
                    idOfUsersToDelete.Add(user.UserId);
                }
                var userRolesToDelete  = dbContext.UserRoles.Where((ur) => ur.RoleId == roleToDelete.RoleId || idOfUsersToDelete.Contains(ur.UserId)).ToList();
                dbContext.Roles.Remove(roleToDelete);
                dbContext.Users.RemoveRange(usersToDelete);
                dbContext.UserRoles.RemoveRange(userRolesToDelete);
                dbContext.SaveChanges();
            }
        }

        public static Dictionary<string, bool> rolenameToDictionary(string rolename)
        {
            var role = getRole(rolename);
            var roleDict = new Dictionary<string, bool>();
            roleDict["IsAdmin"] = role.IsAdmin;
            roleDict["CanAddClasses"] = role.CanAddClasses;
            roleDict["CanUpdateClasses"] = role.CanUpdateClasses;
            roleDict["CanDeleteClasses"] = role.CanDeleteClasses;
            roleDict["CanAddRecords"] = role.CanAddRecords;
            roleDict["CanUpdateRecords"] = role.CanUpdateRecords;
            roleDict["CanDeleteRecords"] = role.CanDeleteRecords;
            return roleDict;
        }

        public static Dictionary<string, bool> usersRoles(string username)
        {
            var user = LoginController.retrieveUser(username);
            var allRolesDict = new Dictionary<string, bool>();
            var allRoles = getAllRoles();
            foreach(var role in allRoles)
            {
                allRolesDict.Add(role.Name, false);
            }
            using (var dbContext = new ApplicationDbContext())
            {
                var userRoles = (
                    from r in dbContext.Roles
                    join ur in dbContext.UserRoles on r.RoleId equals ur.RoleId
                    where ur.UserId == user.UserId
                    select r
                ).ToList();
               
                foreach(var role in userRoles)
                {
                    allRolesDict[role.Name] = true;
                }
                return allRolesDict;
            }
        }

        public static Role getRole(string rolename)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var role = dbContext.Roles.Where((r) => r.Name == rolename).FirstOrDefault();
                return role;
            }
        }
        public static void updateRole(string rolename, Dictionary<string, bool> permissions)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                Role roleToBeChanged = dbContext.Roles.Where(r => r.Name == rolename).FirstOrDefault();
                roleToBeChanged.IsAdmin = permissions["IsAdmin"];
                roleToBeChanged.CanAddClasses = permissions["CanAddClasses"];
                roleToBeChanged.CanUpdateClasses = permissions["CanUpdateClasses"];
                roleToBeChanged.CanDeleteClasses = permissions["CanDeleteClasses"];
                roleToBeChanged.CanAddRecords = permissions["CanAddRecords"];
                roleToBeChanged.CanUpdateRecords = permissions["CanUpdateRecords"];
                roleToBeChanged.CanDeleteRecords = permissions["CanDeleteRecords"];
                dbContext.SaveChanges();
            }
        }

        public static void updateUsersRoles(string username, Dictionary<string, bool> permissions)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                User user = dbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
                var allUsersRoles = dbContext.UserRoles.Where(ur => ur.UserId == user.UserId);
                dbContext.UserRoles.RemoveRange(allUsersRoles);
                var newRoles = new List<UserRole>();
                foreach(var permission in permissions)
                {
                    if (permission.Value)
                    {
                        UserRole newRole = new UserRole();
                        newRole.UserId = user.UserId;
                        newRole.RoleId = dbContext.Roles.Where(r => r.Name == permission.Key).Select(r => r.RoleId).FirstOrDefault();
                        newRoles.Add(newRole);
                    }
                }
                dbContext.UserRoles.AddRange(newRoles);
                dbContext.SaveChanges();
            }
        }
    }
}
