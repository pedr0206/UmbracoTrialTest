using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DrawSubmition
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProductSerialNumber { get; set; }
        public int Age { get; set; }

        public DrawSubmition(string firstName, string lastName, string email, string productSerialNumber, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ProductSerialNumber = productSerialNumber;
            Age = age;
        }
        public DrawSubmition()
        {

        }
    }
}
