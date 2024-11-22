

namespace Lesson_8__Constructor.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Languages { get; set; }
        public string Publisher { get; set; }
   
        public string Genre { get; set; }
        public int Price { get; set; }

    }

}
