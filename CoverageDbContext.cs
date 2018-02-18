using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using ProjectDosApplication.Models;

namespace ProjectDosApplication.Database
{
    public class CoverageDbContext : DbContext
    {

        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<CoverageInformation> CoverageInformations { get; set; }
        public IDbSet<CoveredIndividual> CoveredIndividuals { get; set; }
        public IDbSet<Recipient> Recipients { get; set; }
        public IDbSet<RecipientPolicy> RecipientPolicies { get; set; }
        public IDbSet<UsState> UsStates { get; set; }

        public CoverageDbContext() : base("Server=Saroj-PC;Database=HealthIinsuranceMarketPlace;Trusted_Connection=True;")
        {

        }


        

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            return base.ValidateEntity(entityEntry, items);
        }
    }
}