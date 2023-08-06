using Apartment.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApartmentDbContext _apartmentDbContext;

        public UnitOfWork(ApartmentDbContext apartmentDbContext)
        {
            _apartmentDbContext = apartmentDbContext;
        }

        public async Task SaveChanges()
        {
            await _apartmentDbContext.SaveChangesAsync();
        }
    }
}
