using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loaf_and_latte_system.Factories
{
    namespace LoafAndLatteSystem.Factories
    {
        public abstract class User
        {
            public string Username { get; set; }
            public string Role { get; set; }
            public abstract void SetPermissions();
        }

        public class AdminUser : User
        {
            public override void SetPermissions()
            {
                Role = "Admin";
                // Admin permissions (e.g., manage employees, generate reports)
            }
        }

        public class StaffUser : User
        {
            public override void SetPermissions()
            {
                Role = "Staff";
                // Staff permissions (e.g., view products, manage sales)
            }
        }

        public static class UserFactory
        {
            public static User CreateUser(string role)
            {
                return role switch
                {
                    "Admin" => new AdminUser(),
                    "Staff" => new StaffUser(),
                    _ => null
                };
            }
        }
    }

}
