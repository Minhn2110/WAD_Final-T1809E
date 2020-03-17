using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("MyConnectionString")
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}