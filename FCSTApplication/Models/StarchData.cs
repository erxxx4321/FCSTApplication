using System;
using System.ComponentModel.DataAnnotations;

namespace FCSTApplication.Models
{
    public class StarchData
    {
        public int Id { get; set; }
        public string Week { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int? ChinaShandongPrice { get; set; }
        public int? ThaiPrice { get; set; }
        public int? CornPrice { get; set; }
        public int? WheatPrice { get; set; }
    }
}
