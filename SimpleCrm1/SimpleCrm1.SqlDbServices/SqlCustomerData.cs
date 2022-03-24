using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCrm1.SqlDbServices
{
    public class SqlCustomerData : ICustomerData
    {
        private readonly SimpleCrmDbContext dbContext;
        public SqlCustomerData(SimpleCrmDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Customer Get(int id)
        {
            return dbContext.Customers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return dbContext.Customers.ToList();
        }

        public void Save(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return;
        }
    }
}
