using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models;

public class Member
{
    public string MemberId { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime MemberSince { get; }

    private List<Book> _borrowedBooks = new();
    public IReadOnlyList<Book> BorrowedBooks => _borrowedBooks;

    public Member(string memberId, string name, string email)
    {
        MemberId = memberId;
        Name = name;
        Email = email;
        MemberSince = DateTime.Now;
    }

    public void BorrowBook(Book book)
    {
        _borrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        _borrowedBooks.Remove(book);
    }

    public string GetInfo()
    {
        return $"{Name} ({MemberId}) - Lånade böcker: {_borrowedBooks.Count}";
    }
}

