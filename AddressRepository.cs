using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectDosApplication.Database;
using ProjectDosApplication.Models;

namespace ProjectDosApplication.Repository
{
    public class AddressRepository :  GenericRepository<CoverageDbContext, Address>, IAddressRepository

    {
    }
}