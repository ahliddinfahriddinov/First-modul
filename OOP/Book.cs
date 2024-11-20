
namespace OOP;
public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Languages { get; set; }
    public string Publisher { get; set; }
    public int PublishedYear { get; set; }
    public string Genre { get; set; }
    public int Price { get; set; }
    public string Translator { get; set; }
    public int Units { get; set; }

    public void InfoBook()
    {
        Console.WriteLine($"Book name : {Name}");
        Console.WriteLine($"Author name : {Author}");
        Console.WriteLine($"Languages : {Languages}");
        Console.WriteLine($"Publisher : {Publisher}");
        Console.WriteLine($"Translator : {Translator}");
        Console.WriteLine($"Genre : {Genre}");
        Console.WriteLine($"Prices : {Price}");

    }
    public void BooKUnits()
    {
        Console.WriteLine($"{Name} this book is {Pages} pages");
    }
    public void OnlineOrderBook()
    {
        if(Units > 0)
        {
            Console.WriteLine("The order is accepted");
        }
        else
        {
            Console.WriteLine("The book is not on sale");
        }
    }
}
