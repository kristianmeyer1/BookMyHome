using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Host
    {
        [Key]
        public int HostId { get; set; }
        [Required]
        public string HostName { get; set; }
        [Required]
        public string HostEmail { get; set; }
        [Required]
        public int HostAge { get; set; }

        public Host(int hostId, string hostName, string hostEmail, int hostAge)
        {
            HostId = hostId;
            HostName = hostName;
            HostEmail = hostEmail;
            HostAge = hostAge;
        }
    }
}
