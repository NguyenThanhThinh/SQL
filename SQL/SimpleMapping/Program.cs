using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMapping
{
    using Models;
    using DTO;
    using AutoMapper;
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureAutoMapper();

            Employee employee = GetEmployee();

            EmployeeDto employeeDto = Mapper.Map<Employee, EmployeeDto>(employee);

            Console.WriteLine($"{employeeDto.LastName} {employeeDto.LastName} - {employeeDto.Salary}");
        }

        private static Employee GetEmployee()
        {
            return new Employee()
            {
                FirstName = "Thinh",
                LastName = "Thanh",
                Address = "Can tho",
                BirthDate = new DateTime(1997, 07, 09),
                Salary = 1000000000m
            };
        }

        private static void ConfigureAutoMapper()
        {
            Mapper.Initialize(config => config.CreateMap<Employee, EmployeeDto>());
        }
    }
   
}
