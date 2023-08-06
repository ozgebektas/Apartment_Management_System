using Apartment.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class Bill:IEntity
    {
        public int BillId { get; set; }
        public decimal GasBill { get; set; }
        public decimal WaterBill { get; set; }
        public decimal ElectricityBill { get; set; }
        public decimal Payment { get; set; }
        public DateTime Month { get; set; }
        public bool PaymentStatus { get; set; }
        public int ResidenceId { get; set; }
        public Residence Residence { get; set; }
    }
}
