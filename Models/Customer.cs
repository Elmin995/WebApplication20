using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication20.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthplace { get; set; }
        public string Gender { get; set; }
        public string Identityno { get; set; }
        public int? Identitypincode { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
