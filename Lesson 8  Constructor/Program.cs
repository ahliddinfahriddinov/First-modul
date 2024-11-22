using Lesson_8__Constructor.Models;
using Lesson_8__Constructor.Services;
namespace Lesson_8__Constructor;
internal class Program
{
    static void Main(string[] args)
    {
        GetFrontEnd();
    }

    public static void GetFrontEnd()
    {
        var BookService = new BookService();

        while (true)
        {

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Upddate");
            Console.WriteLine("4. GetAll");
            Console.WriteLine("5. GetById");
            Console.Write("Enter : ");

            var option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                var book = new Book();
                Console.Write("Enter name :");
                book.Name = Console.ReadLine();
                Console.Write("Enter Author name :");
                book.Author = Console.ReadLine();
                Console.Write("Enter pages :");
                book.Pages = int.Parse(Console.ReadLine());
                Console.Write("Enter languages :");
                book.Languages = Console.ReadLine();
                Console.Write("Enter publisher :");
                book.Publisher = Console.ReadLine();
                Console.Write("Enter price :");
                book.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter genre :");
                book.Genre = Console.ReadLine();
                BookService.AddBook(book);
            }
            else if (option == 2)
            {
                Console.Write("Enter Id you want to delete ");
                var Id = Guid.Parse(Console.ReadLine());
                var getRemove = BookService.DeleteBook(Id);
                Console.WriteLine(getRemove);
            }
            else if (option == 3)
            {
                var book = new Book();
                Console.Write("Enter id to change :");
                var Id = Guid.Parse(Console.ReadLine());
                book.Name = Console.ReadLine();
                Console.Write("Enter Author name :");
                book.Author = Console.ReadLine();
                Console.Write("Enter pages :");
                book.Pages = int.Parse(Console.ReadLine());
                Console.Write("Enter languages :");
                book.Languages = Console.ReadLine();
                Console.Write("Enter publisher :");
                book.Publisher = Console.ReadLine();
                Console.Write("Enter price :");
                book.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter genre :");
                book.Genre = Console.ReadLine();

                BookService.UpdateBook(book);
            }
            else if (option == 4)
            {
                var books = BookService.GetBooks();
                foreach (var book in books)
                {
                    var info = $"Id : {book.Id} , Name : {book.Name} Author : {book.Author}," +
                      $" Page : {book.Pages} , Language : {book.Languages}, Publisher : {book.Publisher}" +
                      "Price : {book.Price} , Genre : {book.Genre} ";
                    Console.WriteLine($"{info}");


                }
            }
            else if (option == 5)
            {
                Console.Write("Enter Id to get : ");
                var Id = Guid.Parse(Console.ReadLine());
                var book = BookService.GetById(Id);
                var info = $"Id : {book.Id} , Name : {book.Name} Author : {book.Author}," +
                    $" Page : {book.Pages} , Language : {book.Languages}, Publisher : {book.Publisher}" +
                    $"Price : {book.Price} , Genre : {book.Genre} ";
                Console.WriteLine($"{info}");
            }


        }
        Console.ReadKey();
        Console.Clear();
    }

}

