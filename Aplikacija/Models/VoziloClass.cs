using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplikacija.Models
{
    public class VoziloClass
    {
        public int VoziloId { get; set; }
        [Required(ErrorMessage = "Marka vozila je obavezna!")]
        [StringLength(30,ErrorMessage ="Minimalni broj karaktera : 3 ; Maksimalni broj karaktera : 30", MinimumLength = 5)]
        public string Marka { get; set; }
        public Nullable<int> Model { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> Kreiran { get; set; }
        public Nullable<System.DateTime> Izmenjen { get; set; }
        [Required(ErrorMessage = "Opis vozila je obavezan!")]
        public string Opis { get; set; }
        public string SlikaProizvoda { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(int), "1", "200", ErrorMessage = "Nemoguća količina")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "800000", ErrorMessage = "Nemoguća cena")]
        public Nullable<decimal> Cena { get; set; }

    }
}