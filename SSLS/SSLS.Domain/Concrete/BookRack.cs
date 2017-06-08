using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLS.Domain.Concrete
{
    public class BookRack
    {
        private List<Book> lineCollection = new List<Book>();
        public void AddItem(Book book)
        {
            Book line = lineCollection.Where(e => e.Id == book.Id).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(book);
            }
            else
            {
                return;
            }
        }
        public IEnumerable<Book> Lines
        {
            get { return lineCollection; }
        }
        public void RemoveLine(int id)
        {
            lineCollection.RemoveAll(e => e.Id == id);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }
        
        public int Count()
        {
            return lineCollection.Count;
        }
    }
}
