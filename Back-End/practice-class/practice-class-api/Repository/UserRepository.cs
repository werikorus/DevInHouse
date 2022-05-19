using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_class_api.Models;


namespace practice_class_api.Repository
{
    public class UserRepository
    {
        public static List<User> VerifyUserAndPassword(string username, string password)
        {
            var users = new List<User>();
            

            return users.Where(x => x.Username == username && x.Password == password).ToList();      
        }
    }
}
