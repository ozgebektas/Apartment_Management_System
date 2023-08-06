using Apartment.EntityLayer.Dtos;
using Apartment.EntityLayer.Entities.Concrete;
using Apartment.EntityLayer.Entities.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Core.Mapping
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<AppUser, UserLoginDtıo>().ReverseMap();
            CreateMap<AppUser, AdminLoginDto>().ReverseMap();

        }
    }
}
