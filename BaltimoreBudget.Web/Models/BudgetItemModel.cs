using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaltimoreBudget.Web.Models
{
    public class BudgetItemModel
    {
        public double Amount { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TotalCategory { get; set; }
        public string BudgetGroup { get; set; }
        public bool Selected { get; set; }
    }
}