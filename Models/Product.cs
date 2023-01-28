using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication20.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string MadedBy { get; set; }
        public DateTime? ProductDate { get; set; }
        public decimal? Price { get; set; }
    }
}
