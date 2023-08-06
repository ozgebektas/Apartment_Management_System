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
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(ApartmentDbContext apartmetDbContext, DbSet<Message> dbSet) : base(apartmetDbContext, dbSet)
        {
        }
    }
}
