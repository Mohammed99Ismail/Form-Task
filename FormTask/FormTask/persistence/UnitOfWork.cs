using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormTask.Core;
using FormTask.Core.Repositories;
using FormTask.Models;
using FormTask.persistence.Repositories;

namespace FormTask.persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClientsDbContext _context;

        public UnitOfWork(ClientsDbContext context)
        {
            _context = context;
            Clients = new ClientRepository(_context);
            Countries = new CountryRepository(_context);
            Cities = new CityRepository(_context);
        }

        public IClientRepository Clients { get; private set; }
        public ICityRepository Cities { get; private set; }
        public ICountryRepository Countries { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}