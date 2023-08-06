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
    public class DueRepository : GenericRepository<Due>, IDueRepository
    {
        public DueRepository(ApartmentDbContext apartmetDbContext, DbSet<Due> dbSet) : base(apartmetDbContext, dbSet)
        {

        }
    }
}
