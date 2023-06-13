using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Models;

namespace Lab05.Singleton
{
    public class UserDict
    {
        private UserDict()
        {
        }
        private static UserDict _instance;
        private static readonly object _lock = new object();
        public static UserDict Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserDict();
                    }
                    return _instance;
                }
            }
        }
        public Dictionary<int, User> Users { get; set; } = new ();
        public void Add(User user)
        {
            this.Users.Add(user.ID, user);
        }
        public void Remove(int id)
        {
            this.Users.Remove(id);
        }
        public void Update(int id, User user)
        {
            this.Users[id] = user;
        }
        public User Get(int id)
        {
            return this.Users[id];
        }
        public List<User> GetAll()
        {
            return this.Users.Values.ToList();
        }
    }
}