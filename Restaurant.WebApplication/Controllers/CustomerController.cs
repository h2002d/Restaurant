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
using Restaurant.WebApplication.Repository;

namespace Restaurant.WebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private TestDBContext _dbContext;
        private ICustomerRepository _customerRepository;
        private IHostingEnvironment _hostingEnvironment;
        public CustomerController(ILogger<CustomerController> logger, TestDBContext dbContext, IHostingEnvironment hostingEnvironment,ICustomerRepository customerRepository)
        {
            _logger = logger;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _customerRepository = customerRepository;
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
                customer = _customerRepository.GetCustomers(true);
                viewName = "All_Wholesale";
            }
            else if (User.IsInRole("RS_Retail_Operator"))
            {
                customer = _customerRepository.GetCustomers(false);
                viewName = "All_Retail";
            }
            else
            {
                customer = _customerRepository.GetCustomers(null);
                viewName = "All_Wholesale";
            }
            CustomerHelper.FilterCustomer(ref customer,name,lastname,regName,phonenumber,email);
            return View(viewName, customer);
        }
    }
}