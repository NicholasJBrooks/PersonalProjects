using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankFinance.Models
{
    public class Transaction
    {
        Guid TransactionId { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a transaction type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter an amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public string Category { get; set; }
    }
}
