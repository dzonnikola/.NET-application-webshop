using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class Kupovina
    {
        public int SlanjeId { get; set; }
        [Required]
        public Nullable<int> KlijentId { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Grad { get; set; }
        [Required]
        public string Zemlja { get; set; }
        [Required]
        public string PK { get; set; }
        public Nullable<int> NarudzbinaId { get; set; }
        public Nullable<decimal> Vrednost { get; set; }
        [Required]
        public string Placanje { get; set; }
    }
}