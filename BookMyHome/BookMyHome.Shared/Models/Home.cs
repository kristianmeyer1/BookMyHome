using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class Home
    {
        [Key]
        public int HomeId { get; set; }
        [Required]
        public string HomeType { get; set; }
        [Required]
        public string HomeAdress { get; set; }
        [Required]
        public int HomeSize { get; set; }
        [Required]
        public int HomeBeds { get; set; }
        [Required]
        public int HomeBathrooms { get; set; }
        [Required]
        public string HomeRules { get; set; }
        [Required]
        public int HomeStars { get; set; }

        public Home(int homeId, string homeType, string homeAdress, int homeSize, int homeBeds, int homeBathrooms, string homeRules, int homeStars)
        {
            HomeId = homeId;
            HomeType = homeType;
            HomeAdress = homeAdress;
            HomeSize = homeSize;
            HomeBeds = homeBeds;
            HomeBathrooms = homeBathrooms;
            HomeRules = homeRules;
            HomeStars = homeStars;
        }
    }
}
