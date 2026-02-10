using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models;

public class Loan
{
    public Book Book { get; }
    public Member Member { get; }
    public DateTime LoanDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }

    public bool IsReturned => ReturnDate != null;

    public bool IsOverdue =>
        !IsReturned && DateTime.Now > DueDate;

    public Loan(Book book, Member member, DateTime loanDate, DateTime dueDate)
    {
        Book = book;
        Member = member;
        LoanDate = loanDate;
        DueDate = dueDate;

        book.Borrow();
        member.BorrowBook(book);
    }

    public void Return()
    {
        ReturnDate = DateTime.Now;
        Book.Return();
        Member.ReturnBook(Book);
    }
}
