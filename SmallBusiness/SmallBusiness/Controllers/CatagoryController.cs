using SmallBusiness.BLL.BLL;
using SmallBusiness.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallBusiness.Controllers
{
    public class CatagoryController : Controller
    {
        // GET: Catagory
        CatagoryManager _catagoryManager = new CatagoryManager();
        private Catagory _catagory = new Catagory();
        public ActionResult Add()
        {
            // _student.ID = 101;
            _catagory.Code = "001";
            _catagory.Name = "MobilePhone";
            _catagoryManager.Add(_catagory);

            return View();

        }
        public ActionResult Delete()
        {
            _catagory.ID = 1;

            _catagoryManager.Delete(_catagory);

            return View();
        }

        public ActionResult Update()
        {
            _catagory.ID = 2;
            Catagory aCatagory = _catagoryManager.GetByID(_catagory);
            if (aCatagory != null)
            {
                aCatagory.Name = "Mobile";
                _catagoryManager.Update(aCatagory);
            }

            return View();
        }
        public ActionResult GetByID()
        {
            // _product.Id = 3;

            _catagoryManager.GetByID(_catagory);

            return View();
        }

        public ActionResult GetAll()
        {

            List<Catagory> bCatagory = _catagoryManager.GetAll();

            return View();
        }
    }
}