using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        public string GuestName { get; set; }
        [Required]
        public string GuestEmail { get; set; }
        [Required]
        public int GuestAge { get; set; }

        public Guest(int guestId, string guestName, string guestEmail, int guestAge)
        {
            GuestId = guestId;
            GuestName = guestName;
            GuestEmail = guestEmail;
            GuestAge = guestAge;
        }
    }
}
