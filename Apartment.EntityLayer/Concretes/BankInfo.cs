using Apartment.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class BankInfo:IEntity
    {
        public int BankInfoId { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
       

        
    }
}
