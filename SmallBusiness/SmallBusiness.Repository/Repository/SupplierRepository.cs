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
   public class SupplierRepository
    {
        SmallBusinessDbContext db = new SmallBusinessDbContext();
        public bool Add(Supplier supplier)
        {
            int isExecuted = 0;
            db.Suppliers.Add(supplier);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Supplier supplier)
        {
            int isExecuted = 0;
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            if (aSupplier != null)
            {
                db.Suppliers.Remove(aSupplier);
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Supplier supplier)
        {
            int isExecuted = 0;

            db.Entry(supplier).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public Supplier GetByID(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            return aSupplier;
        }
    }
}
