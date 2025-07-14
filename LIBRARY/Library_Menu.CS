using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> books = new List<string>
        {
            "The Hobbit",
            "1984",
            "To Kill a Mockingbird",
            "The Great Gatsby",
            "Harry Potter and the Sorcerer's Stone"
        };

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. View all books");
            Console.WriteLine("2. Search book by title");
            Console.WriteLine("3. Exit");
            Console.Write("Option: ");
            
            // Add input validation
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("Library books: ");
                    for (int i = 0; i < books.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {books[i]}");
                    }
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
                
                case 2:
                    Console.Write("Enter book title to search: ");
                    string bookName = Console.ReadLine();
                    
                    string searchResult = SearchByBookName(books, bookName);
                    Console.WriteLine(searchResult);
                    
                    if (searchResult != "Book not found")
                    {
                        Console.Write("Do you want to take it? (yes/no): ");
                        string option = Console.ReadLine()?.ToLower();
                        
                        switch (option)
                        {
                            case "yes":
                                RemoveBook(books, bookName);
                                Console.WriteLine($"You have taken '{bookName}'. It has been removed from the library.");
                                break;
                            case "no":
                                Console.WriteLine("Book remains in the library.");
                                break;
                            default:
                                Console.WriteLine("Please enter yes or no");
                                break;
                        }
                    }
                    
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
                
                case 3: 
                    Console.WriteLine("Thank you for using the library system!");
                    return;
                    
                default:
                    Console.WriteLine("Please enter number between 1-3");
                    break;
            }
        }
    }

    public static string SearchByBookName(List<string> books, string bookName)
    {
        var foundBook = books.FirstOrDefault(book => 
            book.Equals(bookName, StringComparison.OrdinalIgnoreCase));
        
        if (foundBook != null)
        {
            return $"Here is your book: {foundBook}";
        }
        
        return "Book not found";
    }

    public static void RemoveBook(List<string> books, string bookName)
    {
        var bookToRemove = books.FirstOrDefault(book => 
            book.Equals(bookName, StringComparison.OrdinalIgnoreCase));
        
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
        }
    }
}