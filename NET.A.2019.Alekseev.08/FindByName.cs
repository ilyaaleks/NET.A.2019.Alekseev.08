using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{
    class FindByName : IFinder
    {
        List<Book> books;
        string name;
        public FindByName(string name,List<Book> books)
        {
            this.name = name;
            this.books = books;
        }
        public Book FindByTeg()
        {
            return books.FirstOrDefault(book => book.Author == name);
        }
    }
}
