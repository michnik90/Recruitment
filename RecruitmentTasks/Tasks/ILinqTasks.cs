using RecruitmentTasks.Models;
using System.Collections.Generic;

namespace RecruitmentTasks.Tasks
{
    public interface ILinqTasks
    {
        List<Customer> GetCustomersBelowAgeOfFourty(List<Customer> customers);
        List<string> GetListOfFirstNames(List<Customer> customers);
        (string, int)[] GetNamesAndSalariesOfRichPeople(List<Customer> customers);
        int SumAllSalariesOfCustomers(List<Customer> customers);
    }
}