// Q1.	Create a class called "Book" with provided attributes
using static System.Reflection.Metadata.BlobBuilder;

class Book
{

    //Q2. Implementing appropriate getter and setter methods 
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public bool Available { get; set; }

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
    public List<Book> books;
    //Q4. Constructor class that initializes an empty list of books
    public Library() {
        books = new List<Book>();
    }

    //Q5.1. AddBook method takes book object as a parameter and add it to the list of books in the library
    
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    //Q5.2 RemoveBook takes ISBN as a parameter and removes book that matches the ISBN

    public void RemoveBook(string ISBN)
    {
        Book bookToRemove = books.Find(book=>book.ISBN == ISBN);
        if(bookToRemove != null)
        {
            books.Remove(bookToRemove);
        }
    }

    //Q5.3 DisplayBooks displays all the books of the Library

    public void DisplayBook()
    {
        foreach(Book book in  books)
        {
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.ISBN);
            Console.WriteLine(book.PublicationYear);
            Console.WriteLine(book.Available);
        }
    }


}