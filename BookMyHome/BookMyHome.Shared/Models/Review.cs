using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public DateTime ReviewDate { get; set; }
        [Required]
        public string ReviewDesciption { get; set; }
        [Required]
        public int ReviewStars { get; set; }

        public Review(int reviewId, DateTime reviewDate, string reviewDesciption, int reviewStars)
        {
            ReviewId = reviewId;
            ReviewDate = reviewDate;
            ReviewDesciption = reviewDesciption;
            ReviewStars = reviewStars;
        }
    }
}
