using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormTask.Models
{
    public enum Gender { Male = 1, Female = 2 };
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Country Country { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Gender gender { get; set; }
    }
}