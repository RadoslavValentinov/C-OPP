using System;
using PizzaCalories.Models;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            try
            {
                string[] piza = Console.ReadLine().Split();
                string namePizza = piza[1];

                string[] dough = Console.ReadLine().Split();
                string doughName = dough[1];
                string beaking = dough[2];
                double weight = double.Parse(dough[3]);

                Dough doughs = new Dough(doughName,beaking,weight);
                Pizza pizza = new Pizza(namePizza, doughs);

                string inputtopping = Console.ReadLine();

                while (inputtopping !="END")
                {
                    string[] splited = inputtopping.Split();
                    string nameTopping = splited[1];
                    double weights = double.Parse(splited[2]);

                    Topping topping = new Topping(nameTopping, weights);

                    pizza.AddTopping(topping);

                    inputtopping = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateAllCalories():F2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}