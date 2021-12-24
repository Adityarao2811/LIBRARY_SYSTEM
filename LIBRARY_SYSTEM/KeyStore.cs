using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY_SYSTEM
{
    public static class KeyStore
    {
        public static string AuthorDBFilePath = @"C:\Users\pc\source\repos\LIBRARY_SYSTEM\LIBRARY_SYSTEM\Authors.txt";
        public static string BooksDBFilePath = @"C:\Users\pc\source\repos\LIBRARY_SYSTEM\LIBRARY_SYSTEM\AuthorBooks.txt";

        public static string AuthorAlreadyExistsMessage = "Author already exists";

        public static string AuthorDoesNotExistMessage= "Author does not exist";

        public static string BorrowersDBFilePath= @"C:\Users\pc\source\repos\LIBRARY_SYSTEM\LIBRARY_SYSTEM\BooksBorrowers.txt";

        public static string BookIsAlreadyBorrowed = "Book is already Borrowed";
    }
}
