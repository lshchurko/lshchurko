using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_homework5
{
    class Book
    {
       string Title;
       int Pages;
       string Indentificator;

       public Book (string title, int pages, string indentificator)
        {
            Title = title;
            Pages = pages;
            Indentificator = indentificator;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetPages()
        {
            return Pages;
        }

        public string GetId()
        {
            return Indentificator;
        }
    }
}
