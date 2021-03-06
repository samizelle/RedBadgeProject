﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Customer
{
    public interface ICustomerRepository
    {
        Task<bool> CreateCustomer(CustomerCreateRAO rao);
        Task<IEnumerable<CustomerListRAO>> GetCustomerList(int id);
        Task<CustomerListRAO> GetCustomerById(int id);
        Task<bool> EditCustomer(CustomerEditRAO rao);
        Task<bool> DeleteCustomer(int id);
    }
}
