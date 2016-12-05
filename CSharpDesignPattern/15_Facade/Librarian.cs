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
            if(location != null)
            {
                LendingList lendingList = new LendingList();
                if(lendingList.Check(bookName))
                {
                    return "貸出中です";
                }
                else
                {
                    return location;
                }
            }
            else
            {
                return "その本は所蔵していません";
            }
        }
    }
}
