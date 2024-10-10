namespace _7.student_grade_management
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
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter amount of grades to process: ");
            int input = int.Parse(Console.ReadLine());
            int[] grade = new int[input];
            
            for (int i = 0; i < input; i++) {
                Console.Write($"Enter grade {i+1}: ");
                int input1 = int.Parse(Console.ReadLine());
                grade[i] = input1;
            }
            Student grades = new Student(name, grade);

            grades.DisplayGrades();
            Console.WriteLine();
            Console.WriteLine($"{grades.CalculateAverage():.00}");

        }
    }
}
