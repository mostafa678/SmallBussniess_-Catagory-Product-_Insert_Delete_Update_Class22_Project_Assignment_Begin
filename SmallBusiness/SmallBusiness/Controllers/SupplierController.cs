using SmallBusiness.BLL.BLL;
using SmallBusiness.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallBusiness.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager = new SupplierManager();
        private  Supplier _supplier = new Supplier();
        public ActionResult Add()
        {
            // _student.ID = 101;
            _supplier.Code = "001";
            _supplier.Name = "Karim";
            _supplier.Address = "Mirpur";
            _supplier.Email = "Karim@writeme.com";
            _supplier.Contact = "Dhaka";
            _supplier.ContactPerson = "Jamal";
            _supplierManager.Add(_supplier);

            return View();

        }
        public ActionResult Delete()
        {
            _supplier.ID = 1;

            _supplierManager.Delete(_supplier);

            return View();
        }

        public ActionResult Update()
        {
            _supplier.ID = 2;
            Supplier aSupplier = _supplierManager.GetByID(_supplier);
            if (aSupplier != null)
            {
                aSupplier.Name = "Rahim";
                _supplierManager.Update(aSupplier);
            }

            return View();
        }
    }
}