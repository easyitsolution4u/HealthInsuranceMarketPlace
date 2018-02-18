using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectDosApplication.Database;
using ProjectDosApplication.Models;

namespace ProjectDosApplication.Repository
{
    public class ReceipientRepository
        : GenericRepository<CoverageDbContext, Recipient>, IRecipientRepository
    {
        public Recipient GetRecipientById(int recipientId)
        {
            {
                return this.FindBy(rec => rec.Id == recipientId).SingleOrDefault();
            }
        }
    }
}