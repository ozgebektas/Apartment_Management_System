using Apartment.EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.EntityLayer.Entities.Concrete
{
    public class Admin:IEntity
    {
        public int AdminID { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
        
    }
}
