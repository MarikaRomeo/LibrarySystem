using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{


    public class Book : ISearchable
    {
        public string ISBN { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public bool IsAvailable { get; private set; }

        public Book(string isbn, string title, string author, int publishedYear)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublishedYear = publishedYear;
            IsAvailable = true;
        }

        public void Borrow()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public string GetInfo()
        {
            return $"{Title} av {Author} ({PublishedYear}) - " +
                   (IsAvailable ? "Tillgänglig" : "Utlånad");
        }

        public bool Matches(string searchTerm)
        {
            searchTerm = searchTerm.ToLower();

            return Title.ToLower().Contains(searchTerm)
                || Author.ToLower().Contains(searchTerm)
                || ISBN.ToLower().Contains(searchTerm);
        }
    }
}

