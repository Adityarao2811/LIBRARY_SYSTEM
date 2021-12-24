using System;
using System.Collections.Generic;

namespace LIBRARY_SYSTEM
{
    class Program
    {
        static string name;
        static Author a;
        static List<Author> authorsList = new List<Author>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Enter 1 to add a book\n Enter 2 to view books\n Enter 3 to borrow a book\n Enter 4 to return a book\n Enter 5 to add an Author\n Enter 6 to display authors\n Enter 7 to see available books\n Enter 8 to display Borrowers List\n Enter 9 to exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        DisplayBooks();
                        break;
                    case "3":
                        AddBorrowerandBook();
                        break;
                    case "4":
                        ReturnBook();
                        break;
                    case "5":
                        AddAuthor();
                        break;
                    case "6":
                        if (authorsList.Count == 0)
                        {
                            Console.WriteLine("No Authors");
                            break;
                        }
                        foreach (Author s in authorsList)
                        {
                            s.DisplayBooks();
                            Console.WriteLine("**********");
                        }
                        break;
                    case "7":
                        DisplayAvailableBooks();
                        break;
                    case "8":
                        DisplayBorrowersList();
                        break;
                    case "9":
                        Console.WriteLine("Goodbye. Have a nice day!\n ______________________________________________________");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("________________________________________________________________________________");
            }
        }

        private static void DisplayBorrowersList()
        {
            foreach (Author s in authorsList)
            {
                s.DisplayBorrowersList();
            }

        }

        private static void DisplayAvailableBooks()
        {
            foreach (Author s in authorsList)
            {
                s.DisplayAvailableBooks();
            }
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Enter the Author's name");
            name = Console.ReadLine();
            AuthorDBReader.AddAuthor(name);
        }

        private static void ReturnBook()
        {
            Console.WriteLine("Enter the Author's name");
            name = Console.ReadLine();
            a = Author.FindAuthor(authorsList, name);
            if (a == null)
            {
                Console.WriteLine("This Author does not exist");
                return;
            }
            Console.WriteLine("Enter the name of book");
            a.ReturnBook(Console.ReadLine());
        }

        private static void AddBorrowerandBook()
        {
            Console.WriteLine("Enter the name of book");
            string book = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string borrower = Console.ReadLine();
            BorrowerDBReader.AddBorrower(book, borrower);
        }

        private static void DisplayBooks()
        {
            Console.WriteLine("Enter the Author's name");
            name = Console.ReadLine();
            a = Author.FindAuthor(authorsList, name);
            if (a == null)
            {
                Console.WriteLine("This Author does not exist");
                return;
            }
            a.DisplayBooks();
        }

        private static void AddBook()
        {
            Console.WriteLine("Enter the Author's name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the book name");
            BooksDBReader.AddBook(name,Console.ReadLine());
        }
    }
}
