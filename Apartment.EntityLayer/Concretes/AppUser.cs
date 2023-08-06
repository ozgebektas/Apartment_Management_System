using Apartment.EntityLayer.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string TCNo { get; set; }
        public string PhoneNumber { get; set; }
        public string VehiclePlateNumber { get; set; }
        public int ResidenceId { get; set; }
        public Residence Residence { get; set; }
        public ICollection<Message> Messages{ get; set; }
        public ICollection<BankInfo> BankInfos{ get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
