book_homework5.Book book1 = new book_homework5.Book ("Neznajka",167,"123ADF125av4") ;
book_homework5.Book book2 = new book_homework5.Book ( "Vij",58,"dvdffv12ds" );
book_homework5.Book book3 = new book_homework5.Book ("Tom Sojer", 132, "987654dvd" );
book_homework5.Book book4 = new book_homework5.Book ("Dinka", 334,"85jfuie45" );
book_homework5.Book book5 = new book_homework5.Book ( "ABC",88, "09dneuie34");

book_homework5.Book[] books = { book1, book2, book3, book4, book5 };
foreach (book_homework5.Book item in books)
{
    Console.WriteLine("Book title {0}, Quantity of pages {1}, Id Number {2}",item.GetTitle(),item.GetPages(), item.GetId());
}
