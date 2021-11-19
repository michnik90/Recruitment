using RecruitmentTasks.Models;
using System.Collections.Generic;

namespace RecruitmentTasks.Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
        Customer GetCustomerById(int id);
        List<Customer> GetCustomers();
        Customer UpdateCustomer(Customer customer);
    }
}