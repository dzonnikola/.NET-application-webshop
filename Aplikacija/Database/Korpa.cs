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
    
    public partial class Korpa
    {
        public int KorpaId { get; set; }
        public Nullable<int> VoziloId { get; set; }
        public Nullable<int> KlijentId { get; set; }
        public Nullable<int> StatusKorpeId { get; set; }
    
        public virtual Vozilo Vozilo { get; set; }
    }
}
