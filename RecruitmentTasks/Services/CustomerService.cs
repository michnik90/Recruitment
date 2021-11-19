using RecruitmentTasks.Datasource;
using RecruitmentTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTasks.Services
{
    public class CustomerService : ICustomerService
    {
        List<Customer> _customers;

        public CustomerService()
        {
            _customers = CustomerDatabase.customers;
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(e => e.Id == id);
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customers.RemoveAll(e => e.Id == id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var found = _customers.FindIndex(e => e.Id == customer.Id);

            if (found != -1)
                _customers[found] = customer;
            else
                throw new NullReferenceException($"Customer of {customer.Id} does not exist.");

            return _customers[found];
        }
    }
}
