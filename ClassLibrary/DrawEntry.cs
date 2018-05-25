using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DrawEntry
    {
        public string Email { get; set; }
        public string ProductSerialNumber { get; set; }

        public DrawEntry(string email, string productSerialNumber)
        {
            Email = email;
            ProductSerialNumber = productSerialNumber;
        }
    }
}
