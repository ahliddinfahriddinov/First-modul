
namespace OOP;
public class Animal
{
    public string Name { get; set; }
    public string Living { get; set; }
    public int Weigth { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public string Category { get; set; }
    public string Feed { get; set; }
    public string Color { get; set; }
    public int LifeSpan { get; set; }
    public double Speed { get; set; }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine($"Weigth : {Weigth}");
        Console.WriteLine($"Height : {Height}");
        Console.WriteLine($"Speed : {Speed}");
        Console.WriteLine($"LifeSpan : {LifeSpan}");
        Console.WriteLine($"Color : {Color}");
        Console.WriteLine($"Feed : {Feed}");
        Console.WriteLine($"Living : {Living}");
        Console.WriteLine($"Category : {Category}");
    }
    public void RemainingLife()
    {
        var counter = 0;
        if (Age < LifeSpan)
        {
            counter = LifeSpan - Age;
        }
        Console.WriteLine($"Qolgan umri : {counter}");

    }


}
