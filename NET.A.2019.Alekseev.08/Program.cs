using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book(12, "ilya", "Garry", "Kennady", "1971", 192, 270.89);
            BookListService service = new BookListService();
            foreach(Book book in service.books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
