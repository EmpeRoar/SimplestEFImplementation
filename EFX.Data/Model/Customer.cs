using System;
using System.Collections.Generic;
using System.Text;

namespace EFX.Data.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Sports { get; set; }
    }
}
