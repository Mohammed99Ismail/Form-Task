using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormTask.Models;

namespace FormTask.ViewModel
{
    public enum Gender { Male = 1, Female = 2 };
    public class ViewClientCountry
    {
        public Client ClientView { get; set; }
        public IEnumerable<Country> CountryView { get; set; }
        public IEnumerable<City> CityView { get; set; }
        public Gender gender { get; set; }

    //public int CityId { get; set; }

}
}