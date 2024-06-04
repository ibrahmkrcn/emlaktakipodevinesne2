using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakTakip.Models
{
    public class Properties
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string PropertyType { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int Price { get; set; }

        public int Area { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int NumberOfFloors { get; set; }
        public int ListingDate { get; set; }
        public string Status { get; set; }

        public virtual List<Listing> Listing { get; set; }    
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }


    }
}
