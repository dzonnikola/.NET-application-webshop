﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProdajaKamionaEntities : DbContext
    {
        public ProdajaKamionaEntities()
            : base("name=ProdajaKamionaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<Korpa> Korpas { get; set; }
        public virtual DbSet<Slanje> Slanjes { get; set; }
        public virtual DbSet<StatusKorpe> StatusKorpes { get; set; }
        public virtual DbSet<Tbl_SlideImage> Tbl_SlideImage { get; set; }
        public virtual DbSet<UlogaKlijent> UlogaKlijents { get; set; }
        public virtual DbSet<Uloge> Uloges { get; set; }
        public virtual DbSet<Vozilo> Voziloes { get; set; }
    }
}
