using System.Collections;
using System.Collections.Generic;

namespace UVM.Theatre.Domain.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Director { get; set; }
        public string ShowDates { get; set; }
        public string Description { get; set; }
        public bool Archive { get; set; }
        public string Image { get; set; }
        public List<DateTime> Dates { get; set; }
        public DateTime Date { get; set; }
        public decimal StudentPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SeniorPrice { get; set; }
    }
}
