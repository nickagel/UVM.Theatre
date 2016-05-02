using System.Collections;
namespace UVM.Theatre.Domain.Models
{
    public class Show : IEnumerable
    {
        public int ShowId { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Director { get; set; }

        public string ShowDates { get; set; }

        public string Description { get; set; }

        public bool Archive { get; set; }

        public string Image { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
