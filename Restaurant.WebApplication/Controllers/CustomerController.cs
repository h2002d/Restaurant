using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.WebApplication.Data;
using Restaurant.WebApplication.Helpers;
using Restaurant.WebApplication.Models;
using Restaurant.WebApplication.Repository.Customer;

namespace Restaurant.WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private TestDBContext _dbContext;
        private CustomerRepository customerRepository;
        private IHostingEnvironment _hostingEnvironment;
        public CustomerController(ILogger<CustomerController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            customerRepository = new CustomerRepository(dbContext);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All(string name, string lastname, string regName, string phonenumber, string email)
        {
            var customer = new List<Customers>();
            string viewName = String.Empty;
            if (User.IsInRole("RS_Wholesale_Operator"))
            {
                customer = customerRepository.GetCustomers(true);
                viewName = "All_Wholesale";
            }
            else if (User.IsInRole("RS_Retail_Operator"))
            {
                customer = customerRepository.GetCustomers(false);
                viewName = "All_Retail";
            }
            else
            {
                customer = customerRepository.GetCustomers(null);
                viewName = "All_Wholesale";
            }
            CustomerHelper.FilterCustomer(ref customer,name,lastname,regName,phonenumber,email);
            return View(viewName, customer);
        }
    }
}