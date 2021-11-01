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
            // Define mapping profile for object, you can define multiple here
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
