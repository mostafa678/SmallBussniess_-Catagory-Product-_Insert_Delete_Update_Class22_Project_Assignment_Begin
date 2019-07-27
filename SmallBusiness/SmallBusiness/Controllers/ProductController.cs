using SmallBusiness.BLL;
using SmallBusiness.Models.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmallBusiness.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        // GET: Product
        ProductManager _productManager = new ProductManager();
        private Product _product = new Product();

        public ActionResult Add()
        {
            // _student.ID = 101;
            _product.Code = "003";
            _product.Name = "Nokia";
            _product.ReorderLevel = 10;
            _product.Description = "Nokia Ds";
            _productManager.Add(_product);

            return View();

        }
        public ActionResult Delete()
        {
            _product.ID = 1;

            _productManager.Delete(_product);

            return View();
        }

        public ActionResult Update()
        {
            _product.ID = 4;
            Product aProduct = _productManager.GetByID(_product);
            if (aProduct != null)
            {
                aProduct.Name = "Samsung";
                _productManager.Update(aProduct);
            }

            return View();
        }
        public ActionResult GetByID()
        {
           // _product.Id = 3;

            _productManager.GetByID(_product);

            return View();
        }

        public ActionResult GetAll()
        {

            List<Product> bProduct = _productManager.GetAll();

            return View();
        }

    }
}