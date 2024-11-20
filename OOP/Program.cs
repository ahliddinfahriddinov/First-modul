namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Student firstStudent = new Student();
        firstStudent.Name = "Ahliddin";
        firstStudent.LastName = "Fahriddinov";
        firstStudent.Age = 29;
        firstStudent.UniversityName = "PDP University";

        Student secondStudent = new Student();
        secondStudent.Name = "Aziza";
        secondStudent.LastName = "Farxodova";
        secondStudent.Age = 19;
        secondStudent.UniversityName = "oxford University";


        Student thirdStudent = new Student();
        thirdStudent.Name = "Azizbek";
        thirdStudent.LastName = "Bahodirov";
        thirdStudent.Age = 21;
        thirdStudent.UniversityName = " Harvard University";


        Student fourthStudent = new Student()
        {
            Name = "Lazizbek",
            LastName = "Nosirov",
            Age = 30,
            UniversityName = "Jaxon tillari universiteti",


        };
        Student fifthStudent = new Student()
        {
            Name = "Kamola",
            LastName = "Olimova",
            Age = 18,
            UniversityName = "Pedogogika Universiteti",


        };

        firstStudent.DisplayInfo();
        secondStudent.DisplayInfo();
        thirdStudent.DisplayInfo();
        fourthStudent.DisplayInfo();
        fifthStudent.DisplayInfo();


        var Animals = new List<Animal>();

        Animal firstAnimal = new Animal()
        {
            Name = "Gepard",
            Category = "Wild",
            Living = "Africa",
            Weigth = 60,
            Height = 100,
            LifeSpan = 25,
            Age = 13,
            Speed = 12,
            Color = "Yellow Black",
            Feed = "Meat"
        };
        Animal secondAnimal = new Animal()
        {
            Name = "Rabbit",
            Category = "Pet",
            Living = "Asia",
            Weigth = 10,
            Height = 40,
            LifeSpan = 12,
            Age = 4,
            Speed = 60,
            Color = "White",
            Feed = "Vegatable"
        };

        Animal thirdAnimal = new Animal()
        {
            Name = "Dolphin",
            Category = "SeaAnimal",
            Living = "Ocean",
            Weigth = 100,
            Height = 150,
            LifeSpan = 25,
            Age = 15,
            Speed = 100,
            Color = "Blue",
            Feed = "Fish"
        };

        firstAnimal.DisplayInfo();
        firstAnimal.RemainingLife();


        secondAnimal.DisplayInfo();
        secondAnimal.RemainingLife();


        thirdAnimal.DisplayInfo();
        thirdAnimal.RemainingLife();



        var Restaurants = new List<Restaurant>();

        Restaurant firstRestaurant = new Restaurant()
        {
            Name = "EVOS",
            Since = 2010,
            Address = "Toshkent",
            Dishes = "Lavash,Burger,Donar , Xot Dog",
            Employees = 500,
            Price = 25000 - 50000,
            Category = "Fast Food",
            SpecialDish = "Lavash",
            Opening = 11,
            Closing = 24,


        };
        firstRestaurant.OrderSpecialDish();
        firstRestaurant.InfoRestaurant();

        Console.Write("Enter time :");
        var time = int.Parse(Console.ReadLine());
        firstRestaurant.OpenOrClosed(time);


        Restaurant secondRestaurant = new Restaurant()
        {
            Name = "Apex Pizza",
            Since = 2014,
            Address = "Toshkent",
            Dishes = "Meat pizza,Cheeze pizza,Chikken pizza and etc ",
            Employees = 300,
            Price = 50000,
            Category = "Fast Food",
            SpecialDish = "Season four pizza",
            Opening = 10,
            Closing = 22,


        };

        secondRestaurant.InfoRestaurant();
        secondRestaurant.OrderSpecialDish();
        Console.Write("Enter time :");
        var time = int.Parse(Console.ReadLine());
        secondRestaurant.OpenOrClosed(time);

        Restaurant thirdRestaurant = new Restaurant()
        {
            Name = "Axmad Jo'Ja",
            Since = 2016,
            Address = "Toshkent",
            Dishes = "Shashlik,Barbekyu,Lag'mon,Evropa taomlari",
            Employees = 200,
            Price = 60000,
            Category = "Restaurant",
            SpecialDish = "Qovurilgan tovuq",
            Opening = 10,
            Closing = 23,


        };
        thirdRestaurant.InfoRestaurant();
        thirdRestaurant.OrderSpecialDish();

        Console.Write("Enter time :");
        var time = int.Parse(Console.ReadLine());
        thirdRestaurant.OpenOrClosed(time);


        var Books = new List<Book>();

        Book firstBook = new Book()
        {
            Name = "Manupulative dictators",
            Author = "Cergey Guriyev & Daniel Treysman",
            Pages = 280,
            Translator = "Otabek Abdullayev",
            Languages = "Uzbek",
            PublishedYear = 2021,
            Publisher = "Tirilish",
            Price = 69000,
            Genre = "Political",
            Units = 0
        };
        firstBook.InfoBook();
        firstBook.OnlineOrderBook();
        firstBook.BooKUnits();

        Book secondBook = new Book()
        {
            Name = "Shaytanat",
            Author = "Tohir Malik",
            Pages = 560,
            Translator = "Otabek Abdullayev",
            Languages = "Uzbek",
            PublishedYear = 2023,
            Publisher = "Tirilish",
            Price = 12400,
            Genre = "Roman",
            Units = 100
        };
        secondBook.InfoBook();
        secondBook.OnlineOrderBook();
        secondBook.BooKUnits();

        Book thirdBook = new Book()
        {
            Name = "Soft Power",
            Author = "Jozev Nay ",
            Pages = 250,
            Translator = "Elbek Nosirov",
            Languages = "Uzbek",
            PublishedYear = 2022,
            Publisher = "Tirilish",
            Price = 58000,
            Genre = "Political",
            Units = 45
        };
        thirdBook.InfoBook();
        thirdBook.OnlineOrderBook();
        thirdBook.BooKUnits();


    }
}
