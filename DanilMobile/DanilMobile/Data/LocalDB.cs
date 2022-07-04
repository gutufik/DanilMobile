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

        public delegate void RefreshList();
        public event RefreshList Refresh;

        public LocalDB(string path)
        { 
            _connection = new SQLiteConnection(path);
            _connection.CreateTable<User>();
            _connection.CreateTable<Expense>();
        }

        public List<User> GetUsers()
        { 
            return _connection.Table<User>().ToList();
        }
        public List<Expense> GetExpenses()
        {
            return _connection.Table<Expense>().ToList(); 
        }

        public List<ExpenseType> GetExpenseTypes()
        {
            return _connection.Table<ExpenseType>().ToList();
        }

        public void SaveUser(User user)
        { 
            _connection.Insert(user);
        }

        public User GetUser(string name, string password)
        { 
            return GetUsers().FirstOrDefault(x => x.Name == name && x.Password == password);
        }

        public void SaveExpense(Expense expense)
        {
            _connection.Insert(expense);
            Refresh.Invoke();
        }
        public void DeleteExpense(Expense expense)
        {
            _connection.Delete(expense);
            Refresh.Invoke();
        }

        public void SaveExpenseType(ExpenseType type)
        {
            _connection.Insert(type);
            Refresh.Invoke();
        }
    }
}
