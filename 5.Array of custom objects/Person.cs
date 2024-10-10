
namespace _5.Array_of_custom_objects
{
    internal class Person
    {
        public string Name;
        public int Age;
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
