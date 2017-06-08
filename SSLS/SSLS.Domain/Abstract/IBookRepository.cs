using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLS.Domain.Concrete;

namespace SSLS.Domain.Abstract
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Reader> Readers { get; }
        IQueryable<Borrow> Borrows { get; }
        IQueryable<Fine> Fines { get; }
        void SaveRack(BookRack bookRack, Reader reader);
        void ReturnBook(int readerId, int bookId);
        bool RenewBook(int readerId, int bookId);
        bool PayFine(int fineId,int readerId);
        void GetFine();
        void ChangePassword(int readerId, string oldPassword,string newPassword);
        void Recharge(int readerId, decimal money);
        void Register(string name, string email, string password);
       
    }
}
