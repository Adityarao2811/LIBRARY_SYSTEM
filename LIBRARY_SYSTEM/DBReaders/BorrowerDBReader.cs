using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LIBRARY_SYSTEM
{
    public static class BorrowerDBReader
    {
        public static Response AddBorrower(string bookName,string borrower)
        {
            Response response = new Response();
            if (BookIsBorrowed(bookName))
            {
            
                  response.Message = KeyStore.BookIsAlreadyBorrowed;
                  response.Status = Status.Failure;
                  return response; 
            }
            using (StreamWriter writer = new StreamWriter(KeyStore.BorrowersDBFilePath, true))
            {
                writer.WriteLine(bookName+" "+borrower);
            }
            response.Status = Status.Success;
            return response;
        }

        private static bool BookIsBorrowed(string bookName)
        {
            string[] lines = File.ReadAllLines(KeyStore.BorrowersDBFilePath);
            foreach (string line in lines)
            {
                if (line.Contains(bookName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
