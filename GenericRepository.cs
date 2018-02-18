using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectDosApplication.Models;


namespace ProjectDosApplication.Repository
{
    public abstract class GenericRepository<Context, ConcreateDomain> 
       :IGenericRepository<Context, ConcreateDomain>
        where Context : DbContext, new ()
        where ConcreateDomain : CoverageBase 

        
    {
        private Context _entities = new Context();
        public Context Entities
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public   virtual IQueryable<ConcreateDomain> GetAll()
        {
            IQueryable<ConcreateDomain> query =  _entities.Set<ConcreateDomain>();
            return query;
        }

        public IQueryable<ConcreateDomain> FindBy(System.Linq.Expressions.Expression<Func<ConcreateDomain, bool>> predicate)
        {

            IQueryable<ConcreateDomain> query = _entities.Set<ConcreateDomain>().Where(predicate);
            return query;
        }

        public virtual void Add(ConcreateDomain entity)
        {
            entity.CreatedBy = "test";
            entity.CreatedDate = DateTime.Now;
            entity.IsActiveRecord = true;
            _entities.Set<ConcreateDomain>().Add(entity);
        }

        public virtual void Delete(ConcreateDomain entity)
        {
            _entities.Set<ConcreateDomain>().Remove(entity);
        }

        public virtual void Edit(ConcreateDomain entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

    }
}