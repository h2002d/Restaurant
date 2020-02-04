using System;
using System.Collections.Generic;

namespace Restaurant.WebApplication.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public string UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyRegNumber { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
