using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormTask.Models;
using FormTask.Core.Repositories;

namespace FormTask.persistence.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ClientsDbContext context)
           : base(context)
        {
        }

        public ClientsDbContext ClientsDbContext
        {
            get { return Context as ClientsDbContext; }
        }
    }
}