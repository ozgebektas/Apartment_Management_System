using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}
