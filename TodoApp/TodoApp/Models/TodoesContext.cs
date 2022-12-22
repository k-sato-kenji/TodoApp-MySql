using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class TodoesContext : DbContext
    {
        public TodoesContext() : base("MyCon")
        {

        }

        public DbSet<todo> todos { get; set; }

    }
}