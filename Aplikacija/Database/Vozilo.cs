//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacija.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vozilo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozilo()
        {
            this.Korpas = new HashSet<Korpa>();
        }
    
        public int VoziloId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Opis { get; set; }
        public Nullable<int> Kolicina { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public string Slika { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korpa> Korpas { get; set; }
    }
}
