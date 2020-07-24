using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormTask.Core.Repositories;

namespace FormTask.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        ICityRepository Cities { get; }
        ICountryRepository Countries { get; }
        int Complete();
    }
}