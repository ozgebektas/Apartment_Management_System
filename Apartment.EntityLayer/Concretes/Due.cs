using Apartment.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class Due:IEntity
    {
        public int DueId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Month { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int AdminID { get; set; }
        public Admin Admin { get; set; }
        public int UserId { get; set; }
        public AppUser User{ get; set; }
    }
}
