namespace COMP003A.Assignment6;
using System;

/* This class represents a book object in the library system, it contains 3 fields (the book 'title', book ID, and checked out status),
   two methods (which display and update the book information), and one constructor (that initializes the fields).
 */
public class Book
{
    public string title;
    public int bookId;
    public bool checkedOut;

    
    // The Book constructor initializes the fields (title, bookid, and checkedout)
    public Book(string title, int bookId, bool checkedOut)
    {
        this.title = title;
        this.bookId = bookId;
        this.checkedOut = checkedOut;
    }

    // The DisplayAllInfo method, displays the information of the books, it will display a message with the book title, book ID, and whether the book has been checked out or not
    public void DisplayAllInfo()
    {
        Console.WriteLine($"Book Title: {title}, Book ID: {bookId}, CheckedOut: {checkedOut}");
    }

    // The ToggleOut method, updates the book status, whether the book is checked out or not
    // (if the book status is already true it'll update it to false and if it's false it'll update the book status to true)
    public void ToggleOut()
    {
        checkedOut = !checkedOut;
        
    }
    
    
}