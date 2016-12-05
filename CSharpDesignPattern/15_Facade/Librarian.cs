using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._15_Facade
{
    class Librarian
    {
        public string SearchBook(string bookName)
        {
            BookList bookList = new BookList();
            string location = bookList.SearchBook(bookName);

            return location;
        }
    }
}
