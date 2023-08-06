using Apartment.EntityLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class Residence:IEntity
    {
        public int ResidenceId { get; set; }
        public string Block { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public int ApartmentNumber { get; set; }
        public string OwnerOrTenant { get; set; }
        public decimal Rent { get; set; }
        public List<AppUser> Users { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
