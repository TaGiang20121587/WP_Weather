using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controls.User
{
    class User
    {
        public String Name { get; set; }
        public String Pass { get; set; }
        public static List<User> getUserDefault()
        {
            List<User>users=new List<User>();
            for (int i = 0; i < 100; i++)
            {
                User u = new User() { Name = "Hoang" + i,Pass="pass" + i };
                users.Add(u);
            }
            return users;
        }
    }
}
