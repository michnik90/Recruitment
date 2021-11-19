using RecruitmentTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTasks.Services
{
    public class InvoiceService : IInvoiceService
    {
        public void AddInvoice(Invoice invoice)
        {
            //Some logic that adds an invoice
        }

        public Invoice GetInvoiceById(Guid Id)
        {
            return new Invoice() { Id = Id };
        }

        public void SaveChangesToInvoice()
        {
            //Some context operation to save changes to updated invoices
        }
    }
}
