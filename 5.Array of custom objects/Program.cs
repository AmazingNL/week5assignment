using System.Diagnostics.Metrics;
using System;

namespace _5.Array_of_custom_objects
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
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++) {
                Console.Write($"Enter a name for person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age for person {i + 1}:");
                int age = int.Parse(Console.ReadLine());
                persons[i] = new Person(name, age);
            }

            PrintPersonArray(persons);
           
        }
        void PrintPersonArray(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("Display all persons");
                Console.WriteLine($"Person{i + 1}");
                persons[i].DisplayPersonInfo();
            }
        }
    }
}
