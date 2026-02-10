using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Test
{
    using LibrarySystem.Models;
    using Xunit;

    public class BookTests
    {
        [Fact]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange & Act
            var book = new Book("978-91-0-012345-6", "Testbok", "Testförfattare", 2024);

            // Assert
            Assert.Equal("978-91-0-012345-6", book.ISBN);
            Assert.Equal("Testbok", book.Title);
            Assert.True(book.IsAvailable);
        }

        [Fact]
        public void IsAvailable_ShouldBeTrueForNewBook()
        {
            var book = new Book("123", "Test", "Author", 2024);

            Assert.True(book.IsAvailable);
        }

        [Fact]
        public void GetInfo_ShouldReturnFormattedString()
        {
            var book = new Book("123", "Test", "Author", 2024);

            var info = book.GetInfo();

            Assert.Contains("Test", info);
            Assert.Contains("Author", info);
            Assert.Contains("Tillgänglig", info);
        }
    }
}
