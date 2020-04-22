using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DataAccess
{
    public class CountryContext : DbContext

    {
        public CountryContext()
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
