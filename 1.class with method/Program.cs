namespace week5assignment
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
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle area = new Rectangle(width, height);
            Console.WriteLine($"Area: {area.CalculateArea(width, height)}");

            Rectangle perimeter = new Rectangle(width, height);
            Console.WriteLine($"Perimeter: {perimeter.CalculateArea(height, width)}");
        }
    }
}
