using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLS.Domain.Abstract;
using System.Timers;

namespace SSLS.Domain.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        private SSLSEntities db = new SSLSEntities();
        private SSLSEntities db1 = new SSLSEntities();

        private List<Borrow> borrows = new List<Borrow>();
        public List<Fine> fines = new List<Fine>();
        public IQueryable<Book> Books
        {
            get { return db.Book; }
        }
        public IQueryable<Category> Categories
        {
            get { return db.Category; }
        }
        public IQueryable<Reader> Readers
        {
            get { return db.Reader; }
        }
        public IQueryable<Borrow> Borrows
        {
            get { return db.Borrow; }
        }
        public IQueryable<Fine> Fines
        {
            get { return db.Fine; }
        }        

        public void SaveRack(BookRack bookRack, Reader reader)
        {
            foreach(var bookrack in bookRack.Lines)
            {
                bool isBorrow = false;
                foreach (var borrow in Borrows)
                {
                    // 还没有借阅
                    if (bookrack.Id == borrow.BookID && borrow.ReaderID==reader.Id && borrow.ReaderReturnDate==null)
                    {
                        isBorrow = true;                       
                    }
                }
                if (isBorrow == false)
                {
                    Borrow dbBorrow = new Borrow();
                    dbBorrow.BookID = bookrack.Id;
                    dbBorrow.BookName = bookrack.Name;
                    dbBorrow.ReaderID = reader.Id;
                    dbBorrow.ReaderName = reader.Name;
                    dbBorrow.BorrowingDate = DateTime.Now;
                    dbBorrow.ShouldReturnDate = DateTime.Now.AddDays(10);
                    dbBorrow.Renew = "0";
                    db.Borrow.Add(dbBorrow);
                    Book dbBook = db.Book.Find(bookrack.Id);
                    dbBook.Status = "外借";
                }               

            }
            db.SaveChanges();
        }
        public void ReturnBook(int readerId, int bookId)
        {
            Borrow myBorrow = db.Borrow.Where(tmp=>tmp.ReaderID==readerId && tmp.BookID==bookId).ToList()[0];            
            if (myBorrow.ReaderReturnDate == null)
            {
                myBorrow.ReaderReturnDate = DateTime.Now;
                Book dbBook = db.Book.Find(bookId);
                dbBook.Status = "在库";
                db.SaveChanges();
            }
            else
            {
                return;
            }
        }
        public bool RenewBook(int readerId, int bookId)
        {
            List<Borrow> dbBorrow = db.Borrow.Where(tmp => tmp.ReaderID == readerId && tmp.BookID == bookId).ToList();
            Borrow myBorrow = null; ;
            foreach (var tmp in dbBorrow)
            {
                myBorrow = tmp;
            }
            //超期 已还 已续借
            if (DateTime.Now > myBorrow.ShouldReturnDate || myBorrow.ReaderReturnDate != null || myBorrow.Renew!="0")
            {
                return false;
            }
            else
            {
                myBorrow.ShouldReturnDate = myBorrow.ShouldReturnDate.AddDays(10);
                myBorrow.Renew = "1";
                db.SaveChanges();
                return true;
            }
        }
        public bool PayFine(int fineId,int readerId)
        {
            Fine fine = db.Fine.Find(fineId);
            Reader reader = db.Reader.Find(readerId);
            if (fine.FineMoney > reader.Money)
            {
                return false;
            }
            if (fine.IsPay == "0")
            {
                fine.IsPay = "1";
                reader.Money -= fine.FineMoney;
                db.SaveChanges();
                return true;
            }
            else
            {
                db.SaveChanges();
                return false;
            }
        }
        public void GetFine()
        {
            List<Borrow> allBorrow = new List<Borrow>();
            foreach (var bor in Borrows)
            {
                if (bor.ReaderReturnDate > bor.ShouldReturnDate)
                {
                    List<Fine> isfine = db1.Fine.Where(tmp => tmp.BookID == bor.BookID && tmp.ReaderID == bor.ReaderID).ToList();
                    if (isfine.Count==0)
                    {
                        Fine fine = new Fine();
                        fine.BookID = bor.BookID;
                        fine.BookName = bor.BookName;
                        fine.ReaderID = bor.ReaderID;
                        fine.ReaderName = bor.ReaderName;
                        fine.BorrowID = bor.Id;
                        fine.FineDate = DateTime.Now;
                        fine.IsPay ="0";
                        TimeSpan overTime = (DateTime)bor.ReaderReturnDate-(DateTime)bor.ShouldReturnDate;
                        fine.OverTime = overTime.Days;
                        fine.FineMoney = overTime.Days * (decimal)1;
                        db.Fine.Add(fine);
                    }
                    else
                    {
                        continue;
                    }
                }  
            }
            db.SaveChanges();        
        }      
        public void ChangePassword(int readerId, string oldPassword,string newPassword)
        {
            Reader reader = db.Reader.Find(readerId);
            if (reader.Password == oldPassword)
            {
                reader.Password = newPassword;
                db.SaveChanges();
            }                      
        }
        public void Recharge(int readerId, decimal money)
        {
            Reader reader = db.Reader.Find(readerId);
            reader.Money =reader.Money+ money;
            db.SaveChanges();
        }
        public void Register(string name, string email, string password)
        {
            Reader reader = new Reader();
            reader.Name = name;
            reader.Money = 10;
            reader.Class = "member";
            reader.Email = email;
            reader.Password = password;
            db.Reader.Add(reader);
            db.SaveChanges();
        }


    }
}
