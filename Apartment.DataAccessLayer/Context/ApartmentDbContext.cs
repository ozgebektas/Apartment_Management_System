using Apartment.EntityLayer.Concretes;
using Apartment.EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.DataAccessLayer.Context
{
    public class ApartmentDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-8JIDE4EC\\SQLEXPRESS; initial catalog=ApartmentDbContext; integrated security=true");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<BankInfo> BankInfos { get; set; }
        public DbSet<Due> Dues { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<AppUser> Users { get; set; }

  
    }


}




