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
    public class ResidenceRepository : GenericRepository<Residence>, IResidenceRepository
    {
        public ResidenceRepository(ApartmentDbContext apartmetDbContext, DbSet<Residence> dbSet) : base(apartmetDbContext, dbSet)
        {
        }
    }
}
