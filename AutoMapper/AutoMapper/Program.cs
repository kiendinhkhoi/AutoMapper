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
                Salary = 100,
                Department = new Department()
                {
                    DeptName = "KDK",
                    DeptAddress = "Vietnam"
                }
            };

            // 3. Start transfer
            EmployeeViewModel employeeViewModel = mapper.Map<Employee, EmployeeViewModel>(source); // ← Transfer Employee to EmployeeViewModel, if your data can't transfer checkout the mapping profile

            // 4. Log result
            LogDetails(employeeViewModel);
            Console.ReadLine();
        }

        private static void LogDetails(EmployeeViewModel employee)
        {
            Console.WriteLine($"Name: {employee.FullName}\nSalary: {employee.Salary}\nDepartment: {employee.DepartName}\nDepartment Address: {employee.DepartAddress}");
            Console.WriteLine($"Title: {employee.Title}\n"); // ← This will be blank(null) because source Employee doesn't have Title property
        }
    }
}
