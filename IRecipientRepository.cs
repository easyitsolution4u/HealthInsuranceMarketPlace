using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDosApplication.Database;
using ProjectDosApplication.Models;

namespace ProjectDosApplication.Repository
{
    public interface IRecipientRepository 
        : IGenericRepository<CoverageDbContext, Recipient>
    {
        Recipient GetRecipientById(int recipientId);
        
    }
}
