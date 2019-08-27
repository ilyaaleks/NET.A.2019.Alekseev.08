using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{
    class FindByISBN : IFinder
    {
        List<Book> books;
        int isbn;
        public FindByISBN(int isbn, List<Book> books)
        {
            this.isbn = isbn;
            this.books = books;
        }
        public Book FindByTeg()
        {
           return  books.FirstOrDefault(book => book.ISBN == isbn);
        }
    }
}
