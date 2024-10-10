
namespace _4.class_with_properties_and_methods
{
    internal class Book
    {
        public string Title {  get; set; }
        public string Author {  get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public void DisplayBookInfo() {
            Console.WriteLine($"Book Information: \n Title: {Title} \n " +
                $"Author: {Author}");
        }
    }
}
