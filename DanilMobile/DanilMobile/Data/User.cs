using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DanilMobile.Data
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

    }
}
