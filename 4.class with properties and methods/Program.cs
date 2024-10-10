namespace _4.class_with_properties_and_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author:");
            string author = Console.ReadLine(); 

            Book bookInfo = new Book(title, author);
            bookInfo.DisplayBookInfo();
        }
    }
}
