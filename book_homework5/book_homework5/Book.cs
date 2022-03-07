using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_homework5
{
    class Book
    {
       public string Title { get; }
       public int Pages { get; }
       public string Indentificator { get; }

     public void DisplayBooks ()
        {
            Console.WriteLine("Book title {0}, Quantity of pages {1}, Id Number {2}", Title, Pages, Indentificator);
        }
       
    }
}
