using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyHome.Shared.Models
{
    public class PhotoCollection
    {
        [Key]
        public int CollectionId { get; set; }

        public PhotoCollection(int collectionId)
        {
            CollectionId = collectionId;
        }
    }
}
