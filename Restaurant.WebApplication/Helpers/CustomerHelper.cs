using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Helpers
{
    public class CustomerHelper
    {
        internal static void FilterCustomer(ref List<Customers> customer, string name, string lastname, string regName, string phonenumber, string email)
        {
            if (!String.IsNullOrEmpty(name))
                customer = customer.Where(x => x.Name.Contains(name)).ToList();
            if (!String.IsNullOrEmpty(lastname))
                customer = customer.Where(x => x.LastName.Contains(lastname)).ToList();
            if (!String.IsNullOrEmpty(regName))
                customer = customer.Where(x => x.CompanyName.Contains(regName)).ToList();
            if (!String.IsNullOrEmpty(phonenumber))
                customer = customer.Where(x => x.PhoneNumber.Contains(phonenumber)).ToList();
        }
    }
}
