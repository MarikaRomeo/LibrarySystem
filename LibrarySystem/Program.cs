// See https://aka.ms/new-console-template for more information
using LibrarySystem.Models;


var library = new Library();

var book1 = new Book("123", "Sagan om ringen", "J.R.R. Tolkien", 1954);
var book2 = new Book("456", "Hobbiten", "J.R.R. Tolkien", 1937);

var member = new Member("M001", "Anna Andersson", "anna@test.se");

library.AddBook(book1);
library.AddBook(book2);
library.AddMember(member);

library.LoanBook("123", "M001");

foreach (var book in library.Search("tolkien"))
{
    Console.WriteLine(book.GetInfo());
}
