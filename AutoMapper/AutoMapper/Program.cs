using AutoMapper.Models;
using AutoMapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<AutoMapperProfile>();
            });

            var mapper = config.CreateMapper();


            Employee employee = new Employee()
            {
                Name = "Source",
                Salary = 1
            };

            // EmployeeViewModel.Title will be null because Employee doesn't have this propery, if vice versa there is no Property name Title will be include in EmployeeViewModel
            EmployeeViewModel employeeViewModel = mapper.Map<Employee, EmployeeViewModel>(employee);
            Console.WriteLine($"{employeeViewModel.Name} - {employeeViewModel.Salary}");

            Console.ReadLine();
        }
    }
}
