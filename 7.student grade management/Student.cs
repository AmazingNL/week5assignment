

namespace _7.student_grade_management
{
    internal class Student
    {
        private String Name;
        private int[] Grades;

        public Student(String name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }
        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.Write($"{Grades[i]},");
            }
        }

        public double CalculateAverage()
        {
            int sum = 0;
           for (int i = 0; i < Grades.Length; i++)
           {
                sum += Grades[i];
           }
           return (double)sum / Grades.Length;
        }
       

    }

}
