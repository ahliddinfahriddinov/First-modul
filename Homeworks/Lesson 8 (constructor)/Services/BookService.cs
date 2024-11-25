using Lesson_8__Constructor.Models;
namespace Lesson_8__Constructor.Services;
public class BookService
{
    private List<Book> books;
    public BookService()    
    {
        books = new List<Book>();
        DataSeed();
    }
    public Book AddBook(Book book)
    {
        book.Id = Guid.NewGuid();
        books.Add(book);
        return book;
    }
    public bool DeleteBook(Guid bookId)
    {
        var exists = false;
        foreach (var book in books)
        {
            if (book.Id == bookId)
            {
                exists = true;
                break;
            }
        }
        return exists;
    }
    public bool UpdateBook(Book updateBook)
    {
        for (var i = 0; i < books.Count; i++)
        {
            if (books[i].Id == updateBook.Id)
            {
                books[i] = updateBook;
                return true;

            }
        }
        return false;
    }
    public Book GetById(Guid bookId)
    {
        foreach (var book in books)
        {
            if (book.Id == bookId)
            {
                return book;
            }
        }
        return null;
    }
    public List<Book> GetBooks()
    {
        return books;
    }

    public void DataSeed()
    {
        Book firstBook = new Book()
        {
            Id = Guid.NewGuid(),
            Name = "Manupulative dictators",
            Author = "Cergey Guriyev & Daniel Treysman",
            Pages = 280,
            Languages = "Uzbek",
            Publisher = "Tirilish",
            Price = 69000,
            Genre = "Political",
        };

        Book secondBook = new Book()
        {
            Id = Guid.NewGuid(),
            Name = "Shaytanat",
            Author = "Tohir Malik",
            Pages = 560,
            Languages = "Uzbek",
            Publisher = "Tirilish",
            Price = 12400,
            Genre = "Roman",
        };
        books.Add(firstBook); 
        books.Add(secondBook); 
    }

}
