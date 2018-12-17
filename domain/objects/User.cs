using System;
using System.Collections.Generic;
using System.Text;

namespace domain.objects
{
    public class User : StorableItem
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }

        public User(int id, string username, string password, string name) : base(id)
        {
            Username = username;
            Password = password;
            Name = name;
        }
    }
}
