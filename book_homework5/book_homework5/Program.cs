using book_homework5;

public class Program
{
    static void Main(string[] args)
    {
        // With constructor
        Book book1 = new Book ("Neznajka",167,"123ADF125av4") ;
        Book book2 = new Book ( "Vij",58,"dvdffv12ds" );
        Book book3 = new Book ("Tom Sojer", 132, "987654dvd" );
        Book book4 = new Book ("Dinka", 334,"85jfuie45" );
        Book book5 = new Book ( "ABC",88, "09dneuie34");
        
        // Without constructor
        //Book book1 = new() {Title = "Neznajka", Pages = 167, Indentificator = "123Aafaf1314"};

        Book[] books = { book1, book2, book3, book4, book5 };

        foreach (Book item in books)
        {
            item.DisplayBook();
        } 
    }
}
