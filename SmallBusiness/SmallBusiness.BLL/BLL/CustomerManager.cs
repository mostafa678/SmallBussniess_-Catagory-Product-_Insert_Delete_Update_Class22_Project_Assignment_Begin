using SmallBusiness.Models.Models;
using SmallBusiness.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }
        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
        public Customer GetByID(Customer customer)
        {
            return _customerRepository.GetByID(customer);
        }
    }
}
