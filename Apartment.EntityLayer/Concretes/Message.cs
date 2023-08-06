using Apartment.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class Message:IEntity
    {
        public int MessageId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public int UserId { get; set; }
        public AppUser User  { get; set; }
        public int AdminID { get; set; }
       public Admin Admin { get; set; }
    }
}
