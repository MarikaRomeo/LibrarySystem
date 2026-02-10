using System;
using System.Collections.Generic;
using System.Text;

using LibrarySystem.Models;
using Xunit;

namespace LibrarySystem.Test
{
    public class SearchTests
    {
        [Fact]
        public void GetTotalBooks_ShouldReturnCorrectCount()
        {
            var library = new Library();

            library.AddBook(new Book("1", "A", "Author", 2000));
            library.AddBook(new Book("2", "B", "Author", 2001));

            Assert.Equal(2, library.TotalBooks());
        }

        [Fact]
        public void GetBorrowedBooksCount_ShouldReturnCorrectCount()
        {
            var library = new Library();
            var book = new Book("1", "A", "Author", 2000);
            var member = new Member("M1", "Anna", "a@test.com");

            library.AddBook(book);
            library.AddMember(member);
            library.LoanBook("1", "M1");

            Assert.Equal(1, library.BorrowedBooksCount());
        }
    }
}
