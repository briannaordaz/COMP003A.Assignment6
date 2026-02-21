// See https://aka.ms/new-console-template for more information
using COMP003A.Assignment6;
using System;

class Program
{
    static void Main()
    {
        Book book1 = new Book("Diary of a wimpy kid", 437829, false);
        Book book2 = new Book("Fahrenheit 451", 492819, true);
        Book book3 = new Book("The Great Gatsby", 402791, true);
        
        
        Console.WriteLine("1. Display All Books\n2. Update One Item\n3. Exit");
       
        int choice;

        do
        {
            Console.WriteLine("Enter Choice: ");
             choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {

                case 1:
                    
                    Console.WriteLine($"item 1: ");

                    book1.DisplayAllInfo();
                    Console.WriteLine($"item 2: ");
                    book2.DisplayAllInfo();
                    Console.WriteLine($"item 3: ");
                    book3.DisplayAllInfo();

                    break;



                case 2:
                    
                    Console.WriteLine("Select Item 1-3: ");
                    int item = Convert.ToInt32(Console.ReadLine());

                    if (item == 1)
                    {
                        book1.ToggleOut();
                        Console.WriteLine("Item 1 successfully updated");
                    }
                    else if (item == 2)
                    {
                        book2.ToggleOut();
                        Console.WriteLine("Item 2 successfully updated");
                    }
                    else if (item == 3)
                    {
                        book3.ToggleOut();
                        Console.WriteLine("Item 3 successfully updated");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                    
                    break;
                    
                


                case 3:
                    
                        Console.WriteLine("Goodbye!!");
                    return;
            }

        }
        while (choice == 1 || choice == 2 || choice == 3);




    }
    
}



/*
example:

1. Display All
   2. Update One Item
   3. Exit
   Enter choice: 1
   
   Item 1: Title=Atomic Habits, Pages=320, Completed=False
   Item 2: Title=Clean Code, Pages=464, Completed=True
   Item 3: Title=The Pragmatic Programmer, Pages=352, Completed=False
   
   Enter choice: 2
   Select item (1-3): 1
   Updated Item 1.
   
   Enter choice: 1
   Item 1: Title=Atomic Habits, Pages=320, Completed=True
   Item 2: Title=Clean Code, Pages=464, Completed=True
   Item 3: Title=The Pragmatic Programmer, Pages=352, Completed=False
   
   Enter choice: 3
   Program ended.
   
*/