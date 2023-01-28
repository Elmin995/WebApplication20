using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication20.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string CountryCode { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public string InsertUser { get; set; }
    }
}
