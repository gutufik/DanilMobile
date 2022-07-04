using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

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
    }
}
