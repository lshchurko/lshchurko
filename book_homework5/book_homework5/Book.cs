namespace book_homework5
{
    class Book
    {
       public string title { get; set; }
       public int pages { get; set;  }
       public string indentificator { get; set; }

       public void displayBooks()
        {
            Console.WriteLine("Book title {0}, Quantity of pages {1}, Id Number {2}", title, pages, indentificator);
        }
    }
}
