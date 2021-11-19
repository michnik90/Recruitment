using Microsoft.Extensions.Logging;
using RecruitmentTasks.Models;
using RecruitmentTasks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RecruitmentTasks.Tasks
{
    public class CodesmellTasks
    {
        private readonly ILogger _logger;
        private readonly IInvoiceService _invoiceService;

        public CodesmellTasks(ILogger logger, IInvoiceService invoiceService)
        {
            _logger = logger;
            _invoiceService = invoiceService;
        }

        public Invoice SetInvoiceTotalCost(Guid? invoiceId, int cost)
        {
            if (invoiceId == Guid.Parse("00000000-0000-0000-0000-000000000000"))
                throw new Exception("Error");

            var invoice = _invoiceService.GetInvoiceById(invoiceId.Value);
            invoice.TotalCost = cost;

            return invoice;
        }

        public async void LongRunningComputation()
        {
            //Some long running operation
            Task.Delay(15000);

            _logger.LogError("Task completed!");
        }

        /// <summary>
        /// This method validates if invoice exist and if total cost is greater than 0. Then adds and invoice to database.       /// </summary>
        /// <param name="Id"></param>
        /// <param name="totalCost"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        public void ValidateAndAddInvoice(Guid? Id, int totalCost, string description, string title)
        {
            if (Id == Guid.Empty)
                throw new ArgumentException("Id cannot be empty!");

            _invoiceService.AddInvoice(new Invoice() { Id = Id.Value, TotalCost = totalCost, Description = description, Title = title  });

            _logger.LogInformation("Invoice added!");
        }
    }
}
