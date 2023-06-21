// Q1.	Create a class called "Book" with provided attributes
using static System.Reflection.Metadata.BlobBuilder;

class Book
{

    //Q2. Implementing appropriate getter and setter methods 
    private string Title { get; set; }
    private string Author { get; set; }
    private string ISBN { get; set; }
    private int PublicationYear { get; set; }
    private bool Available { get; set; }

    static void Main(string[] args)
    {
        Book book = new Book();

        book.Title = "Hello";
        book.Author = "Author";
        book.ISBN = "12345ABCDE";
        book.PublicationYear = 2023;
        book.Available = true;

        Console.WriteLine(book.Title);
        Console.WriteLine(book.Author);
        Console.WriteLine(book.ISBN);
        Console.WriteLine(book.PublicationYear);
        Console.WriteLine(book.Available);

    }
}

    //Q3. Creating another class "Library" with list of Book object
class Library
{
    List<Book> books = new List<Book>();
}