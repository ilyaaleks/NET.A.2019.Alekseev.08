using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{
    [Serializable]
    public class Book:IEquatable<Book>, IComparable, IComparable<Book>
    {
       
        public Book(int iSBN, string author, string title, string publishing_House, string theYearOfPublishing, int numberOfPages, double price)
        {
            ISBN = iSBN;
            Author = author;
            Title = title;
            this.publishing_House = publishing_House;
            this.theYearOfPublishing = theYearOfPublishing;
            this.numberOfPages = numberOfPages;
            this.price = price;
        }

        public int ISBN { get; }
        public string Author { get; }
        public string Title { get; }
        string publishing_House { get; }
        string theYearOfPublishing { get; }
        int numberOfPages { get; }
        double price { get; set; }
        public override string ToString()
        {
            return $"ISBN: {ISBN}; Author: {Author}; Title: {Title}; Year: {theYearOfPublishing}; Price: {price}";
        }
        public string Format()
        {
            return $"{ISBN} {Author} {Title} {publishing_House} {theYearOfPublishing} {numberOfPages} {price} \n";
        }
        public override bool Equals(object obj)
        {
            if(obj is Book && obj!=null)
            {
                Book book = obj as Book;
                return book.ISBN == this.ISBN;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

        public bool Equals(Book other)
        {
            return other.ISBN==this.ISBN;
        }

        public int CompareTo(object bookObj)
        {
            if (ReferenceEquals(bookObj, null)) return 1;
            var book = (Book)bookObj;
            return CompareTo(book);
        }

        public int CompareTo(Book book)
        {
            if (ReferenceEquals(book, null))
            {
                return 1;
            }
            return string.Compare(Title, book.Title);
        }
    }
}
