using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLS.Domain.Abstract;
using SSLS.Domain.Model;

namespace SSLS.Domain.Concrete
{
    public class EFAdminRepository : IAdminRepository
    {
        private SSLSEntities db = new SSLSEntities();
        private SSLSEntities db1 = new SSLSEntities();
        public void DeleteBook(int bookId)
        {
            Book aBook= db.Book.Find(bookId);
            if (aBook != null)
            {
                db.Book.Remove(db.Book.Remove(aBook));
                db.SaveChanges();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            Category aCategory = db.Category.Find(categoryId);
            if (aCategory != null)
            {
                db.Category.Remove(aCategory);
                //db.Category.Remove(db.Category.Remove(aCategory));
                db.SaveChanges();
            }
        }

        public void AddBook(Book book)
        {
            Random ran = new Random();
            int RandKey = ran.Next(1000000, 9999999);                     
            Book abook = new Book
            {
                CategoryID = book.CategoryID,
                Code = RandKey.ToString(),
                Name = book.Name,
                Authors = book.Authors,
                Press = book.Press,
                Description = book.Description,
                Price = book.Price,
                PublishDate=book.PublishDate,
                Status = "在库",
                Num = 5
            };                       
            db.Book.Add(abook);
            db.SaveChanges();
        }
        public void EditBook(Book book)
        {          
            Book aBook = db.Book.Find(book.Id);
            if (aBook != null)
            {
                aBook.CategoryID = book.CategoryID;
                aBook.Name = book.Name;
                aBook.Authors = book.Authors;
                aBook.Press = book.Press;        
            }      
            db.SaveChanges();           
        }
        public void AddCategory(Category category)
        {
            int maxNum = (from cate in db.Category select cate.Id).Max();
            Category aCategory = new Category
            {
                Code = "c" + (maxNum + 1).ToString(),
                Name = category.Name,
                Description = category.Description,
            };
            db.Category.Add(aCategory);
            db.SaveChanges();
        }
        public void EditCategory(Category category)
        {          
            Category aCategory = db.Category.Find(category.Id);
            if (aCategory != null)
            {
                aCategory.Name = category.Name;
                aCategory.Description = category.Description;
            }          
            db.SaveChanges();
        }


        public void DeleteReader(int readerId)
        {
         
            Reader aReader = db.Reader.Find(readerId);
            if (aReader != null)
            {
                db.Reader.Remove(db.Reader.Remove(aReader));
                db.SaveChanges();
            }
        }

        public void SaveReader(Reader reader)
        {
            if (reader.Id== 0)
            {
                db.Reader.Add(reader);              
            }
            else
            {
                Reader aReader = db.Reader.Find(reader.Id);
                if (aReader != null)
                {
                    aReader.Name = reader.Name;
                    aReader.Money = reader.Money;
                    aReader.Class = reader.Class;
                    aReader.Email = reader.Email;
                    aReader.Password = reader.Password;
                }
            }
            db.SaveChanges();
        }

        public bool AdminLogin(string userName, string password)
        {
            Admin admin = db.Admin.FirstOrDefault(user => user.Name == userName && user.Password == password);
            if (admin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CategoryStatistics> GetCategoryStatistics(int num)
        {
            List<CategoryStatistics> listStatistics = new List<CategoryStatistics>();
            var books = from book in db.Book
                        group book by book.CategoryID into summer
                        select new
                        {
                            cateId = summer.Key,
                            bookNum = summer.Count()
                        };
            var bookTake = books.ToList().Take(num);
            foreach (var book in bookTake)
            {
                Category category = db1.Category.FirstOrDefault(tmp => tmp.Id == book.cateId);
                CategoryStatistics statistics = new CategoryStatistics();
                statistics.CategoryName = category.Name;
                statistics.BookNum = book.bookNum;
                listStatistics.Add(statistics);
            }
            return listStatistics;
        }

        public List<BorrowStatistics> GetBorrowStatistics(int num)
        {
            List<BorrowStatistics> listStatistics = new List<BorrowStatistics>();
            var borrows = from borow in db.Borrow
                        group borow by borow.BookName into summer
                        select new
                        {
                            bookName = summer.Key,
                            borrowNum = summer.Count()
                        };
            var borrowkTake = borrows.ToList().Take(num);
            foreach (var borrow in borrowkTake)
            {
                BorrowStatistics statistics = new BorrowStatistics();
                statistics.BookName = borrow.bookName;
                statistics.BorrowNum = borrow.borrowNum;
                listStatistics.Add(statistics);
            }
            return listStatistics;
        }

        public List<FineStatistics> GetFineStatistics()
        {
            throw new NotImplementedException();
        }
    }
   
}
