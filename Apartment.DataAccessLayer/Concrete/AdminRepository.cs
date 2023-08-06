using Apartment.BusinessLayer.Abstract;
using Apartment.Core.Utilities.Results;
using Apartment.DataAccessLayer.Context;
using Apartment.EntityLayer.Entities.Concrete;
using Apartment.EntityLayer.Entities.Dtos;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.BusinessLayer.Concrete
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        
        public AdminRepository(ApartmentDbContext apartmetDbContext, DbSet<Admin> dbSet) : base(apartmetDbContext, dbSet)
        {
           

        }

        
    }
}