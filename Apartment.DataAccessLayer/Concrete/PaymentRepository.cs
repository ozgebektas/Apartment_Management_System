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
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApartmentDbContext apartmetDbContext, DbSet<Payment> dbSet) : base(apartmetDbContext, dbSet)
        {
        }
    }
}
