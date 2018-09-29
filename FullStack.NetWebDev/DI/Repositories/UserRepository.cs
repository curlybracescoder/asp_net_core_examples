using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using DI.Models;

namespace DI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private Dictionary<string, User> userMap = new Dictionary<string, User>();

        public UserRepository()
        {
            userMap["user1"] = new User{Name="User1", Email="User1@gmail.com", Phone="2343455"};
            userMap["user2"] = new User{Name="User2", Email="User2@gmail.com", Phone="2343455"};
            userMap["user3"] = new User{Name="User3", Email="User3@gmail.com", Phone="2343455"};
            userMap["user4"] = new User{Name="User4", Email="User4@gmail.com", Phone="2343455"};
            userMap["user5"] = new User{Name="User5", Email="User5@gmail.com", Phone="2343455"};
            userMap["user6"] = new User{Name="User6", Email="User6@gmail.com", Phone="2343455"};
        }

        public User[] GetAll()
        {
            return userMap.Values.ToArray();
        }

        public User GetByName(string name)
        {
            return userMap[name];
        }
    }
}