using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentTasks.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }

        public int TotalCost { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }
    }
}
