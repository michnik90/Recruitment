using RecruitmentTasks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using RecruitmentTasks.Tasks;
using FluentAssertions;
using System.Linq;
using NUnit.Framework;

namespace RecruitmentTasks.UnitTests.TasksTests
{
    public class LinqTasksTests
    {
        List<Customer> _customers;
        LinqTasks _linqTasks;

        public LinqTasksTests()
        {
            _customers = new List<Customer>()
            {
                new Customer() { Id = 1, FirstName = "John", LastName = "Doe", Age = 20, Salary = 25000 },
                new Customer() { Id = 2, FirstName = "Jane", LastName = "Doe", Age = 23, Salary = 5000 },
                new Customer() { Id = 3, FirstName = "Steve", LastName = "Smith", Age = 55, Salary = 50000 },
                new Customer() { Id = 4, FirstName = "Natalie", LastName = "Connor", Age = 85, Salary = 93500 }
            };

            _linqTasks = new LinqTasks();
        }

        [Test]
        public void Given_ListOfPreparedCustomers_When_CallsGetCustomersBelowAgeOfFourty_Then_ShouldReturnCorrectList()
        {
            var result = _linqTasks.GetCustomersBelowAgeOfFourty(_customers);
            result.Should().HaveCount(2);
            result.Select(e => e.Id).Should().Contain(1);
            result.Select(e => e.Id).Should().Contain(2);
        }

        [Test]
        public void Given_ListOfPreparedCustomers_When_CallsGetListOfFirstNames_Then_ShouldReturnCorrectList()
        {
            var result = _linqTasks.GetListOfFirstNames(_customers);
            result.Should().Contain(new List<string> { "John", "Jane", "Steve", "Natalie" });
        }


        [Test]
        public void Given_ListOfPreparedCustomers_When_CallsGetNamesOfRichPeople_Then_ShouldReturnCorrectList()
        {
            var result = _linqTasks.GetNamesAndSalariesOfRichPeople(_customers);
            result.Should().Contain(new (string, int)[]{ ("John", 25000), ("Steve", 50000), ("Natalie", 93500) });
        }

        [Test]
        public void Given_ListOfPreparedCustomers_When_CallsSumAllSalariesOfCustomers_Then_ShouldReturnCorrectList()
        {
            var result = _linqTasks.SumAllSalariesOfCustomers(_customers);
            result.Should().Be(25000 + 5000 + 50000 + 93500);
        }
    }

}
