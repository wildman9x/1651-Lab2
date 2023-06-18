using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab05.Singleton;

namespace Lab05.Models
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int ID { get; set; } = UserDict.Instance.Users.Count;
        public string FullName { get; set; } = "Unnamed User";
        public User()
        {
        }
        public string GetInfo()
        {
            return $"ID: {ID}\nUsername: {Username}\nFull Name: {FullName}";
        }
    }
}