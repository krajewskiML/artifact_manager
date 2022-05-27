using artifact_manager2.Database.EnhancedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artifact_manager2.Database.Context;
using artifact_manager2.Database.Models;

namespace artifact_manager2.Controllers
{
    internal class LoginController
    {
        public static bool checkIfUserExists(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var user = dbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
                return user != null;
            }
        }

        public static void addRole(Role role)
        {
            using(var dbContext = new ApplicationDbContext())
            {
                dbContext.Roles.Add(role);
                dbContext.SaveChanges();
            }
        }

        public static void addUser(User user)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }

        public static void addUserRole(UserRole userRole)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.UserRoles.Add(userRole);
                dbContext.SaveChanges();
            }
        }

        public static bool checkIfPasswordIsmatching(string username, string password)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var user = dbContext.Users
                    .Where(u => u.UserName == username && u.Password == password)
                    .FirstOrDefault();
                return user != null;
            }
        }

        public static FullUser retrieveUser(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.RetrieveUser(username);
            }
        }

        public static void deleteUser(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var userToDelete = dbContext.Users.Where((u) => u.UserName == username).FirstOrDefault();
                dbContext.Users.Remove(userToDelete);
                dbContext.SaveChanges();
            }
        }

        public static List<User> getAllUsers()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Users.ToList();
            }
        }

        public static void addUser(string username, string password)
        {
            User user = new User() { UserName = username, Password = password};
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }

        public static void updatePassword(string username, string password)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                User userToBeChanged = dbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
                userToBeChanged.Password = password;
                dbContext.SaveChanges();
            }
        }

        public static User getUser(string username)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                User user = dbContext.Users.Where(u => u.UserName == username).FirstOrDefault();
                return user;
            }
        }

        public static Role getRole(string roleName)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                Role role = dbContext.Roles.Where(r => r.Name == roleName).FirstOrDefault();
                return role;
            }
        }
    }
}
