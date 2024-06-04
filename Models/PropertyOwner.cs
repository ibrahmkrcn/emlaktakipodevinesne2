using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakTakip.Models
{
    public class PropertyOwner
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public int PhoneNumber { get; set; }

        public string EmailAdress { get; set; }
        public string Address { get; set; }

        public virtual List<Listing> Listing { get; set; }
    }
}
