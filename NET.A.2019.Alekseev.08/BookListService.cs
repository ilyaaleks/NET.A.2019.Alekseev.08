using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NET.A._2019.Alekseev._08
{
    class BookListService
    {
        string filePath = "";
        public List<Book> books = new List<Book>();

        public BookListService()
        {
            Console.WriteLine("Enter the path to the file");
            filePath = Console.ReadLine();
            if (filePath == null || filePath == " ")
            {
                throw new ArgumentException("Null string");
            }
            LoadBooks();
        }

        public void LoadBooks()
        {
            string[] properties;
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fileStream))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        properties = reader.ReadString().Split(' ');
                        Book book = new Book(
                            Convert.ToInt32(properties[0]),
                            properties[1],
                            properties[2],
                            properties[3],
                            properties[4],
                            Convert.ToInt32(properties[5]),
                            Convert.ToDouble(properties[6]));
                        books.Add(book);
                    }
                }
            }


        }
        public void SaveAllBooks()
        {
            foreach(Book book in books)
            {
                File.Delete(filePath);
                SaveBook(book);
            }
        }
        public void SaveBook(Book book)
        {

            if (!books.Contains(book))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    using (BinaryWriter writter = new BinaryWriter(fileStream))
                    {

                        {
                            writter.Write(book.Format());
                            books.Add(book);
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("This book already exists");
            }
        }
    }
}
