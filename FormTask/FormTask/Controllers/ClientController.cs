using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormTask.Models;
using FormTask.ViewModel;
using FormTask.Core;
using FormTask.persistence;

namespace FormTask.Controllers
{
    public class ClientController : Controller
    {
        //private ClientsDbContext _context;
        private readonly IUnitOfWork _UnitOfWork;
        public ClientController()
        {
            _UnitOfWork = new UnitOfWork(new ClientsDbContext());
        }
        /*protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }*/
        public ActionResult New()
        {
            //var countries = _context.countries.ToList();
            //var cities = _context.cities.ToList();
            var countries = _UnitOfWork.Countries.GetAll();
            var cities = _UnitOfWork.Cities.GetAll();
            var viewmodel = new ViewClientCountry()
            {
                CountryView=countries,
                CityView=cities
            };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Create(ViewClientCountry view)
        {
            var client = new Client();
            client.Name = view.ClientView.Name;
            client.CountryId = view.ClientView.CountryId;
            client.gender = view.ClientView.gender;
            //_context.clients.Add(client);
            //_context.SaveChanges();
            _UnitOfWork.Clients.Add(client);
            _UnitOfWork.Complete();
            return RedirectToAction("New", "Client");
        }
        /*public JsonResult GetCities(int ClientView_CountryId)
        {
            _context.Configuration.ProxyCreationEnabled = false;
            List<City> cities = _context.cities.Where(x => x.CountryId == ClientView_CountryId).ToList();
            return Json(cities, JsonRequestBehavior.AllowGet);
        }*/
    }
}