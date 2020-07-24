using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FormTask.Models
{
    public class ClientsDbContext:DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }

    }
}