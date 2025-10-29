using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class ListingAmmeneties
    {
        [Key]
        public int AmmenetiesId { get; set; }
        [Required]
        public string AmmenetiesName { get; set; }

        public ListingAmmeneties(int ammenetiesId, string ammenetiesName)
        {
            AmmenetiesId = ammenetiesId;
            AmmenetiesName = ammenetiesName;
        }
    }
}
