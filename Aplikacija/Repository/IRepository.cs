using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Aplikacija.Repository
{
    public interface IRepository <Tbl_Entity> where Tbl_Entity:class
    {
        IEnumerable<Tbl_Entity> GetProduct();
        IEnumerable<Tbl_Entity> GetAllRecords();
        IQueryable<Tbl_Entity> GetAllRecordsIQueryable();
        int GetAllrecordCount();
        void Add(Tbl_Entity entity);
        void Update(Tbl_Entity entity);
        Tbl_Entity GetFirstorDefault(int recordId);
        void Remove(Tbl_Entity entity);

    } 
}