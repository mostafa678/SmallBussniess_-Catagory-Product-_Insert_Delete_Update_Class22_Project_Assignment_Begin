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
   public class CustomerRepository
    {
        SmallBusinessDbContext db = new SmallBusinessDbContext();
        public bool Add(Customer customer)
        {
            int isExecuted = 0;
            db.Customers.Add(customer);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Customer customer)
        {
            int isExecuted = 0;
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.ID == customer.ID);
            if (aCustomer != null)
            {
                db.Customers.Remove(aCustomer);
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Customer customer)
        {
            int isExecuted = 0;

            db.Entry(customer).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public Customer GetByID(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.ID == customer.ID);
            return aCustomer;
        }


    }
}
