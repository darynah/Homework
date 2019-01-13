using System;

namespace TaskBookSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book();
        }

        class Book : IComparable
        {
            public string Title;
            public int Theme;

            public string BookCompare(Book book)
            {
                return book.Theme + book.Title;
            }

            public int CompareTo(object obj)
            {
                var book = (Book) obj;
                var book1 = BookCompare(this);
                var book2 = BookCompare(book);
                return book1.CompareTo(book2);
            }
        }
    }

    //class Book : IComparable
    //{
    //    public string Title;
    //    public int Theme;

    //    public int CompareTo(object obj)
    //    {
    //        var book = (Book)obj;
    //        var book1 = Theme + Title;
    //        var book2 = book.Theme + book.Title;
    //        return book1.CompareTo(book2);
    //    }
    //}
}
