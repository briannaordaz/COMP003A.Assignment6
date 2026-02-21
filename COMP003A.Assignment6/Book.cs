namespace COMP003A.Assignment6;
using System;
public class Book
{
    public string title;
    public int bookId;
    public bool checkedOut;

    public Book(string title, int bookId, bool checkedOut)
    {
        this.title = title;
        this.bookId = bookId;
        this.checkedOut = checkedOut;
    }

    public void DisplayAllInfo()
    {
        Console.WriteLine($"Book Title: {title}\nBook Id: {bookId}\nCheckedOut: {checkedOut}");
    }

    public void ToggleOut()
    {
        checkedOut = !checkedOut;
        
    }
    
    
}