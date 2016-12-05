using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._15_Facade
{
    class Visitor
    {
        public static void Main(string[] args)
        {
            var nakamura = new Librarian();
            var location = nakamura.SearchBook("昆虫図鑑");
            if(location.Equals("貸出中です"))
            {
                Console.WriteLine("貸出中かよ…");
            }
            else if(location.Equals("その本は所蔵していません"))
            {
                Console.WriteLine("なんだ、ないのか");
            }
            else
            {
                Console.WriteLine("サンキュ！");
            }
        }
    }
}
