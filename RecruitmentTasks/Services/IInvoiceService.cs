using RecruitmentTasks.Models;
using System;

namespace RecruitmentTasks.Services
{
    public interface IInvoiceService
    {
        Invoice GetInvoiceById(Guid Id);

        void AddInvoice(Invoice invoice);

        void SaveChangesToInvoice();
    }
}