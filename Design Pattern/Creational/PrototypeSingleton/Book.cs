using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSingleton
{
    internal class Book : ICloneable
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int PublishYear { get; set; }

        public Book() { }
        public Book(Book book)
        {
            Name = book.Name;
            Author = book.Author;
            PublishYear = book.PublishYear;
        }

        public object Clone()
        {
            return new Book(this);
        }
    }
}
