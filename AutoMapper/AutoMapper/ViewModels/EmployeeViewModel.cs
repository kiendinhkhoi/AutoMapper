using AutoMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper.ViewModels
{
    class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Salary { get; set; }
        public string Title { get; set; }
        public string DepartName { get; set; }
        public string DepartAddress { get; set; }
    }
}
