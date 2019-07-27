using SmallBusiness.BLL.BLL;
using SmallBusiness.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallBusiness.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerManager _customerManager = new CustomerManager();
        private Customer _customer = new Customer();
        public ActionResult Add()
        {
            // _student.ID = 101;
            _customer.Code = "001";
            _customer.Name = "Karim";
            _customerManager.Add(_customer);

            return View();

        }
        public ActionResult Delete()
        {
            _customer.ID = 1;

            _customerManager.Delete(_customer);

            return View();
        }

        public ActionResult Update()
        {
            _customer.ID = 2;
            Customer aCustomer = _customerManager.GetByID(_customer);
            if (aCustomer != null)
            {
                aCustomer.Name = "Rahim";
                _customerManager.Update(aCustomer);
            }

            return View();
        }
    }
}