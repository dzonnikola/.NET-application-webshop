using Aplikacija.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class Item
    {
        public Vozilo Vozilo { get; set; }
        public int Kolicina { get; set; }
    }
}