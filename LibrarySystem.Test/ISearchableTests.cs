using System;
using System.Collections.Generic;
using System.Text;

using LibrarySystem.Models;
using Xunit;

public class SearchTests
{
    [Theory]
    [InlineData("Tolkien", true)]
    [InlineData("tolkien", true)]
    [InlineData("Rowling", false)]
    public void Book_Matches_ShouldFindByAuthor(string searchTerm, bool expected)
    {
        var book = new Book("123", "Sagan om ringen", "J.R.R. Tolkien", 1954);

        var result = book.Matches(searchTerm);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Book_Matches_ShouldFindByTitle()
    {
        var book = new Book("123", "Hobbiten", "Tolkien", 1937);

        Assert.True(book.Matches("Hobbiten"));
    }
}
