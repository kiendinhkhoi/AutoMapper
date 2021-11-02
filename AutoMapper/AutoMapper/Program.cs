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
        /* Notes:
         * - Destination's properties will be NULL if Source's object doesn't have these properties.
         * - Destination's properties will be UNDEFINED if Source's object doesn't have these properties.
         * - Properties mapping is case insensitive. (ex: "name" can also transfer value to "NAME").
         */
        static void Main(string[] args)
        {
            // 1. Init Automapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            var mapper = config.CreateMapper();

            // 2. Create dummy object
            Employee source = new Employee()
            {
                Name = "Hello world!",
                Salary = 100
            };

            // 3. Start transfer
            EmployeeViewModel employeeViewModel = mapper.Map<Employee, EmployeeViewModel>(source); // ← Transfer Employee to EmployeeViewModel, if your data can't transfer checkout the mapping profile

            // 4. Log result
            Console.WriteLine($"Name: {employeeViewModel.FullName}\nSalary: {employeeViewModel.GrossSalary}\n---");
            Console.ReadLine();
        }
    }
}
