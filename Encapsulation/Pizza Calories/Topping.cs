using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Topping
    {
        private Dictionary<string, double> IngrediantAndWeight = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese" ,1.1},
            {"sauce" , 0.9}
        };

        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (!IngrediantAndWeight.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value;
            }
        }

        public double Calories => 2* Weight * IngrediantAndWeight[this.Name.ToLower()];
    }
}
