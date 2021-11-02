using AutoMapper.Models;
using AutoMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<Employee, EmployeeViewModel>(); // ← Create map with matches properties

            // In case we want to map un-matches properties we could do like this: (Checkout Employee, EmployeeViewModel. We have 2 un-matches properties)
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.GrossSalary, act => act.MapFrom(src => src.Salary));
        }
    }
}
