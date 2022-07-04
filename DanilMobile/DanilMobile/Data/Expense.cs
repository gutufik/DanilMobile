using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DanilMobile.Data
{
    [Table("Expense")]
    public class Expense
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string ExpenseType { get; set; }

        public string RecordType { get; set; }

        public double Amount {  get; set; }

        public DateTime Date { get; set; }

    }
}
