using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLS.Domain.Concrete;
using SSLS.Domain.Model;

namespace SSLS.Domain.Abstract
{
    public interface IAdminRepository
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void DeleteBook(int bookId);
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);
        void SaveReader(Reader reader);
        void DeleteReader(int readerId);
        bool AdminLogin(string userName, string password);
        List<CategoryStatistics> GetCategoryStatistics(int num);
        List<BorrowStatistics> GetBorrowStatistics(int num);
        List<FineStatistics> GetFineStatistics();
    }
}
