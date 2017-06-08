using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Concrete
{
    public class Cart
    {
        private List<CartLine> LineCollection = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine line = LineCollection.Where(e => e.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                LineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public IEnumerable<CartLine> Lines
        {
            get { return LineCollection; }
        }
        public void RemoveLine(Product product)
        {
            LineCollection.RemoveAll(e => e.Product.Id == product.Id);
        }
        public void Clear()
        {
            LineCollection.Clear();
        }
        public decimal ComputeTotalValue()
        {
            return LineCollection.Sum(e => e.Product.Price * e.Quantity);
        }
    }
}
