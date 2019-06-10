using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int SSN { get; set; }
        public Address Address { get; set; }
        public string JobTitle { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public decimal HourlyWage { get; set; }

    }
}
