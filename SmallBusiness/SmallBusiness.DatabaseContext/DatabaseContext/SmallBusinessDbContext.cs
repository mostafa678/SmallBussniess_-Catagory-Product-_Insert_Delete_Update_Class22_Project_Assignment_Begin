using SmallBusiness.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.DatabaseContext.DatabaseContext
{
   public class SmallBusinessDbContext:DbContext 
    {
        public DbSet <Product> Products { get; set; }
        public DbSet <Catagory> Catagories { get; set; }

    }
}
