using Backend.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Demo.DAL
{
    internal class MyDatabaseContext : DbContext 
    {
        //Don't forget for the base it uses the name that we gave to our connection string in the web config file!!!
        public MyDatabaseContext() : base("name=AdhocDb")
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
