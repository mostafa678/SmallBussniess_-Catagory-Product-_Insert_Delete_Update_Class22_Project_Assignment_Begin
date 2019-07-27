using SmallBusiness.DatabaseContext.DatabaseContext;
using SmallBusiness.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.Repository.Repository
{
    public class ProductRepository
    {
        SmallBusinessDbContext db = new SmallBusinessDbContext();
        public bool Add(Product product)
        {
            int isExecuted = 0;
            db.Products.Add(product);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Product product)
        {
            int isExecuted = 0;
            Product aProduct = db.Products.FirstOrDefault(c => c.ID == product.ID);
            if (aProduct != null)
            {
                db.Products.Remove(aProduct);
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Product product)
        {
            int isExecuted = 0;

            db.Entry(product).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public Product GetByID(Product product)
        {
            Product aProduct = db.Products.FirstOrDefault(c => c.ID == product.ID);
            return aProduct;
        }

        public List<Product> GetAll()
        {

            return db.Products.ToList();
        }

    }
}
