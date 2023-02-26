using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FCSTApplication.Models
{
    public class CoalData
    {
        public int Id { get; set; }
        public string Week { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int? CoalPrice_5800 { get; set; }
        public int? CoalPrice_5500 { get; set; }
        public int? CoalPrice_5000 { get; set; }
        public int? SpotPrice_5500 { get; set; }
        public int? BohaiInventory { get; set; }
        public int? PortChinInventory { get; set; }
        public int? DeliveryFee { get; set; }
        public int? NewcPrice { get; set; }
    }
}
