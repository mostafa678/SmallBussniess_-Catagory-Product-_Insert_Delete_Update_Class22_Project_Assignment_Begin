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
  public class CatagoryRepository
    {

        SmallBusinessDbContext db = new SmallBusinessDbContext();
        public bool Add(Catagory catagory)
        {
            int isExecuted = 0;
            db.Catagories.Add(catagory);
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public bool Delete(Catagory catagory)
        {
            int isExecuted = 0;
            Catagory aCatagory = db.Catagories.FirstOrDefault(c => c.ID == catagory.ID);
            if (aCatagory != null)
            {
                db.Catagories.Remove(aCatagory);
                isExecuted = db.SaveChanges();
            }

            if (isExecuted > 0)
                return true;
            return false;
        }
        public bool Update(Catagory catagory)
        {
            int isExecuted = 0;

            db.Entry(catagory).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
                return true;

            return false;
        }
        public Catagory GetByID(Catagory catagory)
        {
            Catagory aCatagory = db.Catagories.FirstOrDefault(c => c.ID == catagory.ID);
            return aCatagory;
        }

        public List<Catagory> GetAll()
        {

            return db.Catagories.ToList();
        }

    }
}
