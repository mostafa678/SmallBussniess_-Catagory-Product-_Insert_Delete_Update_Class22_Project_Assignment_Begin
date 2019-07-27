using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.Models.Models
{
   public class Product
    {
        public  int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double  ReorderLevel{ get; set; } //reorderlavel is not null
        public string  Description { get; set; }

      //  public List<Catagory> Cattegories { get; set; }
}
}
