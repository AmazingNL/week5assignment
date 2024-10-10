using System.Reflection.Metadata.Ecma335;

namespace _3.array_of_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start() {
            Console.WriteLine("Enter 3 integers: ");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            int[] numbers = { input1, input2, input3 };

            Console.WriteLine($" sum: {CalculateSum(numbers)}");
            Console.WriteLine($"Average: {CalculateAverage(numbers):.00}");
        }
        int CalculateSum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
        double CalculateAverage(int[] numbers)
        {
            double average = (double)CalculateSum(numbers)/numbers.Length;
            return average;
        }
        
    }
}
