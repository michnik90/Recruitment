using RecruitmentTasks.Models;
using System.Collections.Generic;

namespace RecruitmentTasks.Datasource
{
    public static class CustomerDatabase
    {
        public static List<Customer> customers = new List<Customer>()
        {
                new Customer() { Id = 1, FirstName = "John", LastName = "Doe", Age = 20, Salary = 25000 },
                new Customer() { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 23, Salary = 5000 },
                new Customer() { Id = 3, FirstName = "Steve", LastName = "Smith", Age = 55, Salary = 50000 },
                new Customer() { Id = 4, FirstName = "Natalie", LastName = "Connor", Age = 85, Salary = 93500 }
        };
    }
}
