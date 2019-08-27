using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{

    class BookListStorage
    {
        BookListService service = new BookListService();
        public void AddBook(Book book)
        {
            service.SaveBook(book);
        }
        public void RemoveBook(Book book)
        {
            if (service.books.Contains(book))
            {
                service.books.Remove(book);
                service.SaveAllBooks();
            }
            else
            {
                throw new ArgumentException("this book does not exist");

            }
        }
        public void FindBookByTag(IFinder finder)
        {
            finder.FindByTeg();
        }
        public void SortBookByTag(IComparer<Book> comparer)
            {
            service.books.Sort(comparer);
}
    }
}
