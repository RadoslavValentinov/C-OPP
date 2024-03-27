using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();


            while (input !="End")
            {
                string[] splited = input.Split();
                string name = splited[0];
                string country = splited[1];
                int age = int.Parse(splited[2]);

                IResident resident = new Citizen(name,country,age);
                IPerson person = new Citizen(name,country,age);

                Console.WriteLine( person.GetName());
                Console.WriteLine( resident.GetName());


                input = Console.ReadLine();


            }
        }
    }
}
