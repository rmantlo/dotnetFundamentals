using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public int AccidentCount { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Premium { get; set; }

        public Customer(  ) {  }
        public Customer(int customerId, string firstName, string lastName, int age, Address address, int accidentCount, string phoneNumber, decimal premium)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            AccidentCount = accidentCount;
            PhoneNumber = phoneNumber;
            Premium = premium;
        }
}
}
