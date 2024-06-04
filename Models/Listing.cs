using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakTakip.Models
{
    public class Listing
    {
        public int Id { get; set; }

        [StringLength(10)]
        public int PropertyId { get; set; }

        [StringLength(50)]
        public int OwnerId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerSurname { get; set; }
        public int BuyerPhonenumber { get; set; }

        public string SaleDate { get; set; }

        public int PaymentAmount { get; set; }
        public virtual List<Properties> Properties { get; set; }
        public virtual List<PropertyOwner> PropertyOwner { get; set; }
    }
}
