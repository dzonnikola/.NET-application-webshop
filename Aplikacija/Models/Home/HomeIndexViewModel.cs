using Aplikacija.Models;
using Aplikacija.Repository;
using Aplikacija.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Aplikacija.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork genericUnitOfWork = new GenericUnitOfWork();
        ProdajaKamionaEntities entities = new ProdajaKamionaEntities();
        public IEnumerable<Vozilo> ListaVozila { get; set; }
        public HomeIndexViewModel KreirajModel(string search)
        {

            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@search",search??(object)DBNull.Value) };
            IEnumerable<Vozilo> data = entities.Database.SqlQuery<Vozilo>("PretragaVozila @search", param).ToList();
            return new HomeIndexViewModel
            {
                ListaVozila = data
            };
            }
        }
    }