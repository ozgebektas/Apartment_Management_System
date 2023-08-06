using Apartment.BusinessLayer.Abstract;
using Apartment.DataAccessLayer.Context;
using Apartment.EntityLayer.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.BusinessLayer.Concrete
{
    public class BillRepository : GenericRepository<Bill>, IBillRepository
    {
        public BillRepository(ApartmentDbContext apartmetDbContext, DbSet<Bill> dbSet) : base(apartmetDbContext, dbSet)
        {
        }
    }
}
