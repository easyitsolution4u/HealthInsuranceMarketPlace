using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDosApplication.Models;

namespace ProjectDosApplication.Repository
{
    public interface IGenericRepository<Context, ConcreateDomain>
       where Context : DbContext, new()
       where ConcreateDomain : CoverageBase
    {
        IQueryable<ConcreateDomain> GetAll();
        IQueryable<ConcreateDomain> FindBy(System.Linq.Expressions.Expression<Func<ConcreateDomain, bool>> predicate);
        void Add(ConcreateDomain entity);
        void Delete(ConcreateDomain entity);
        void Edit(ConcreateDomain entity);
        void Save();
    }
}
