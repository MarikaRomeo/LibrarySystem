using System;
using System.Collections.Generic;
using System.Text;
namespace LibrarySystem.Models;

public class Library
{
    private List<Book> _books = new();
    private List<Member> _members = new();
    private List<Loan> _loans = new();

    public void AddBook(Book book) => _books.Add(book);
    public void AddMember(Member member) => _members.Add(member);

    public IEnumerable<Book> Search(string term)
    {
        return _books.Where(b => b.Matches(term));
    }

    public IEnumerable<Book> SortByTitle()
    {
        return _books.OrderBy(b => b.Title);
    }

    public IEnumerable<Book> SortByYear()
    {
        return _books.OrderBy(b => b.PublishedYear);
    }

    public Loan LoanBook(string isbn, string memberId)
    {
        var book = _books.First(b => b.ISBN == isbn && b.IsAvailable);
        var member = _members.First(m => m.MemberId == memberId);

        var loan = new Loan(book, member, DateTime.Now, DateTime.Now.AddDays(14));
        _loans.Add(loan);

        return loan;
    }

    public int TotalBooks() => _books.Count;

    public int BorrowedBooksCount() =>
        _books.Count(b => !b.IsAvailable);

    public Member MostActiveBorrower()
    {
        return _members
            .OrderByDescending(m => m.BorrowedBooks.Count)
            .First();
    }
}
