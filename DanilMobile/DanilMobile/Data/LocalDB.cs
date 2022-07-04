using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;

namespace DanilMobile.Data
{
    public class LocalDB
    {
        private SQLiteConnection _connection;

        public LocalDB(string path)
        { 
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<User>();
        }

        public List<User> GetUsers()
        { 
            return _connection.Table<User>().ToList();
        }

        public void SaveUser(User user)
        { 
            _connection.Insert(user);
        }

        public User GetUser(string name, string password)
        { 
            return GetUsers().FirstOrDefault(x => x.Name == name && x.Password == password);
        }
    }
}
