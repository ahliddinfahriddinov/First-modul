namespace OOP;
public class Restaurant
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Since { get; set; }
    public string Dishes { get; set; }
    public string Category { get; set; }
    public string SpecialDish { get; set; }
    public int Employees { get; set; }
    public int Price { get; set; }
    public int Opening { get; set; }
    public int Closing { get; set; }

    public void InfoRestaurant()
    {
        Console.WriteLine($"Restaurant name : {Name}");
        Console.WriteLine($"Dish : {Dishes}");
        Console.WriteLine($"Address : {Address}");
        Console.WriteLine($"Since : {Since}");
        Console.WriteLine($"Employees : {Employees}");
        Console.WriteLine($"Prices : {Price}");

    }
    public void OpenOrClosed(int time)
    {

        if (Opening < time && time < Closing)
        {
            Console.WriteLine("Open");
        }
        else
        {
            Console.WriteLine("Close");
        }
    }
    public void OrderSpecialDish()
    {
        Console.WriteLine($"Famous dish : {SpecialDish}");
    }

}