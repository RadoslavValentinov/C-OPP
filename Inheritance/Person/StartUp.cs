using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Person person = null;
            Child child = null;

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 15)
            {
                person = new Person(name,age);
                Console.WriteLine(person.ToString());
            }
            else if (age <= 15)
            {
                child = new Child(name,age);
                Console.WriteLine(child.ToString());
            }
        }
    }
}
