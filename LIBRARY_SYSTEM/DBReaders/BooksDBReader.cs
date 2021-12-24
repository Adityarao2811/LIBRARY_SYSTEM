using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LIBRARY_SYSTEM
{
    public static class BooksDBReader
    {
        public static Response AddBook(string authorName, string bookName)
        {
            Response response = new Response();
            if(!AuthorDBReader.CheckIfAuthorExists(authorName))
            {
                response.Message = KeyStore.AuthorDoesNotExistMessage;
                response.Status = Status.Failure;
                return response;
            }
            using (StreamWriter writer = new StreamWriter(KeyStore.BooksDBFilePath, true))
            {
                writer.WriteLine(authorName+" "+bookName);
                response.Status = Status.Success;
                return response;
            }
        }
    }
}
