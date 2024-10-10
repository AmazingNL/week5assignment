namespace _2.enumeration
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
            Console.WriteLine("Enter a day of the week (e.g. Monday): ");
            string input = Console.ReadLine();

            Day day = (Day)Enum.Parse(typeof(Day), input);

            switch (day) { 
                case Day.Monday:
                    Console.WriteLine("Start of the work week. Let's get things done!");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("It's Tuesday, Weekend is loading...");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("It's Hump Day! Halfway through the week.");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Almost there, it's Thursday!");
                    break;
                case Day.Friday:
                    Console.WriteLine("It's Friday! The weekend is almost here.");
                    break;
                case Day.Saturday:
                    Console.WriteLine("It's the weekend! party time!");
                    break;
                case Day.Sunday:
                    Console.WriteLine("Relax, it's Sunday. Rest up for the week ahead.");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
        }

        }
    }

