using SmallBusiness.Models.Models;
using SmallBusiness.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.BLL.BLL
{
   public class CatagoryManager
    {
        CatagoryRepository _catagoryRepository = new CatagoryRepository();
        public bool Add(Catagory catagory)
        {
            return _catagoryRepository.Add(catagory);
        }
        public bool Delete(Catagory catagory)
        {
            return _catagoryRepository.Delete(catagory);
        }
        public bool Update(Catagory catagory)
        {
            return _catagoryRepository.Update(catagory);
        }
        public Catagory GetByID(Catagory catagory)
        {
            return _catagoryRepository.GetByID(catagory);
        }
        public List<Catagory> GetAll()
        {
            return _catagoryRepository.GetAll();
        }
    }
}
