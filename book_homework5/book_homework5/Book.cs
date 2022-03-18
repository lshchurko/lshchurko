using System;

namespace book_homework5
{
    class Book
    {
        // It's way with constructor
        public string Title { get; set; }
       public int Pages { get; set;  }
       public string Indentificator { get; set; }
       
       public Book(string title, int pages, string id)
       {
           Title = title;
           Pages = pages;
           Indentificator = id;
       }
       
       // Without constructor
       // public string Title { get; set; }
       // public int Pages { get; set;  }
       // public string Indentificator { get; set; }
       

       public void DisplayBook()
        {
            Console.WriteLine("Book title {0}, Quantity of pages {1}, Id Number {2}", Title, Pages, Indentificator);
        }
    }
}
