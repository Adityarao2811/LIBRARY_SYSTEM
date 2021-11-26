using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY_SYSTEM
{
    public class Author
    {
        string Name;
        List<string> Books;
        Dictionary<string, string> Borrowers;
        static int NumberOfAuthors = 0;
        public Author(string n)
        {
            this.Name = n;
            this.Books = new List<string>();
            this.Borrowers = new Dictionary<string, string>();
            NumberOfAuthors++;
        }
        public void DisplayBorrowersList()
        {
            if(this.Borrowers.Count==0)
            {
                Console.WriteLine(this.Name + " books are not borrowed");
                return;
            }
            foreach(var f in this.Borrowers.Keys)
            {
                Console.WriteLine(this.Borrowers[f]);
            }
        }
        public void DisplayAvailableBooks()
        {
            foreach(string b in this.Books)
            {
                if(!this.Borrowers.ContainsKey(b))
                {
                    Console.WriteLine(b);
                }
            }
        }
        public void AddBook(string b)
        {
            this.Books.Add(b);
            Console.WriteLine("Book " + b + " has been added to " + this.Name);
        }
        public void AddBorrowerandBook(string book,string borrower)
        {
            if (this.Books.Contains(book))
            {
                if (this.Borrowers.ContainsKey(book))
                {
                    Console.WriteLine("This book is already borrowed");
                }
                else
                {
                    this.Borrowers[book] = borrower;
                }
            }
            else
            {
                Console.WriteLine("This book is not present");
            }
        }
        public void ReturnBook(string book)
        {
            if (!this.Borrowers.ContainsKey(book))
            {
                Console.WriteLine("This book is not borrowed");
            }
            else
            {
                this.Borrowers.Remove(book);
            }
        }
        public void DisplayBooks()
        {
            if (this.Books.Count == 0)
            {
                Console.WriteLine(this.Name+" has No Books");
            }
            else
            {
                Console.WriteLine("Below are the books of " + this.Name);
                foreach (string b in this.Books)
                {
                    Console.WriteLine(b);
                }
            }
        }
        public static void WhoAreAuthors()
        {
            Console.WriteLine("Authros write Books");
        }
        public static void DisplayNumberOfAuthors()
        {
            Console.WriteLine(Author.NumberOfAuthors);
        }
        public static Author FindAuthor(List<Author> authors,string name)
        {
            return authors.Find(a => a.Name == name);
        }
        }
    }
