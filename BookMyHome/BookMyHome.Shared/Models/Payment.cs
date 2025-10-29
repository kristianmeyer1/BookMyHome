using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string PaymentType { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }

        public Payment(int paymentId, string paymentType, DateTime paymentDate)
        {
            PaymentId = paymentId;
            PaymentType = paymentType;
            PaymentDate = paymentDate;
        }
    }
}
