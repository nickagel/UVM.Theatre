using System.Collections.Generic;
using System.Linq;

namespace UVM.Theatre.Domain.Models
{
    public class Cart
    {
        private readonly List<CartLine> _lineCollection = new List<CartLine>();

        public void AddItem(Show show, int studentQuantity, int regularQuantity, int seniorQuantity)
        {
            var line = _lineCollection
                .FirstOrDefault(p => p.Show.ShowId == show.ShowId);

            if (line == null)
            {
                _lineCollection.Add(new CartLine
                {
                    Show = show,
                    StudentQuantity = studentQuantity,
                    RegularQuantity = regularQuantity,
                    SeniorQuantity = seniorQuantity
                });
            }
            else
            {
                line.StudentQuantity += studentQuantity;
                line.RegularQuantity += regularQuantity;
                line.SeniorQuantity += seniorQuantity;
            }
        }

        public void RemoveLine(Show show)
        {
            _lineCollection.RemoveAll(l => l.Show.ShowId == show.ShowId);
        }

        public decimal ComputeTotalValue()
        {
            return _lineCollection.Sum(e => e.Show.StudentPrice * e.StudentQuantity+e.Show.StudentPrice * e.StudentQuantity + e.Show.StudentPrice * e.StudentQuantity);

        }
        public void Clear()
        {
            _lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines => _lineCollection;
    }

    public class CartLine
    {
        public Show Show { get; set; }
        public int StudentQuantity { get; set; }
        public int RegularQuantity { get; set; }
        public int SeniorQuantity { get; set; }
    }
}