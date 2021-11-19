using RecruitmentTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTasks.Tasks
{
    public class LinqTasks : ILinqTasks
    {
        public List<Customer> GetCustomersBelowAgeOfFourty(List<Customer> customers)
        {
            //Provide implementation
            return customers;
        }

        public List<string> GetListOfFirstNames(List<Customer> customers)
        {
            //Provide implementation
            return new List<string>();
        }

        public (string, int)[] GetNamesAndSalariesOfRichPeople(List<Customer> customers)
        {
            //Provide implementation - return names and salary of people who earn more than 20000.
            return new[] { ("Name", 56000) };
        }

        public int SumAllSalariesOfCustomers(List<Customer> customers)
        {
            //Provide implementation
            return 10000;
        }
    }
}
