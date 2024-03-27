using System;
using System.Collections.Generic;
using System.Linq;
using BirthdayCelebrations;
using FoodShortage;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            IBuyer_ buyer = null;

            List<IBuyer_> buyFood = new List<IBuyer_>();
            List<Citizens> citizen = new List<Citizens>();
            List<Rebel> rebel = new List<Rebel>();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (people.Length==4)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string id = people[2];
                    string birthday = people[3];

                    buyer = new Citizens(name,age,id,birthday);
                    buyFood.Add(buyer);
                    citizen.Add((Citizens)buyer);
                }
                else if (people.Length==3)
                {
                    string name = people[0];
                    int age = int.Parse(people[1]);
                    string group = people[2];

                    buyer = new Rebel(name,age,group);
                    buyFood.Add(buyer);
                    rebel.Add((Rebel)buyer);
                }
            }


            string input = Console.ReadLine();
            while (input !="End")
            {
                if (citizen.Any(x=>x.Name==input))
                {
                    var curentCitizen = citizen.Where(x => x.Name == input).FirstOrDefault();
                    curentCitizen.BuyFood();
                }
                else if (rebel.Any(x=>x.Name==input))
                {
                    var curentRebel = rebel.Where(x => x.Name == input).FirstOrDefault();
                    curentRebel.BuyFood();
                }
                input = Console.ReadLine();
            }

            var citizenfood = citizen.Select(x=>x.Food).Sum();
            var rebalfood = rebel.Select(x=>x.Food).Sum();
            Console.WriteLine($"{citizenfood+rebalfood}");
        }
    }
}
