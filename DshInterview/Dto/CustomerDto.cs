using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DshInterview.Dto
{
    public class CustomerDto
    {
        public string CustomerName { get; set; }

        public string Description { get; set; }

        public string CustomerSince { get; set; }

        public decimal TotalSpent { get; set; }

    }
}