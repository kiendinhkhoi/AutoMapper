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
        /* Notes:
         * - Destination's properties will be NULL if Source's object doesn't have these properties.
         * - Destination's properties will be UNDEFINED if Source's object doesn't have these properties.
         * - Properties mapping is case insensitive. (ex: "name" can also transfer value to "NAME").
         */
        public AutoMapperProfile()
        {
            // -- Case 1: Create map with matches properties
            //CreateMap<Employee, EmployeeViewModel>();

            // -- Case 2: Create map with un-matches properties: (Checkout Employee, EmployeeViewModel. We have 1 un-matches property, that's Name/FullName)
            //CreateMap<Employee, EmployeeViewModel>()
            //    .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.GrossSalary, act => act.MapFrom(src => src.Salary));

            // -- Case 3: Create map from "Complex type" to "Primitive type": 
            CreateMap<Employee, EmployeeViewModel>()
            .ForMember(des => des.FullName, act => act.MapFrom(src => src.Name))
            .ForMember(des => des.DepartName, act => act.MapFrom(src => src.Department.DeptName))
            .ForMember(des => des.DepartAddress, act => act.MapFrom(src => src.Department.DeptAddress));
            // Other matches properties will auto map, we just have to create map for un-match/custom properties.
        }
    }
}
