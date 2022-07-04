using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanilMobile.Data
{
    [Table("ExpenseType")]
    public class ExpenseType
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
