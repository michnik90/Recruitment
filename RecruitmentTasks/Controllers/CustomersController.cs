using Microsoft.AspNetCore.Mvc;
using RecruitmentTasks.Models;
using RecruitmentTasks.Services;
using System.Collections.Generic;

namespace RecruitmentTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return new List<Customer>();
        }

    }
}
