using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrm1
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
    }
}
