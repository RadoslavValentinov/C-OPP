using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> topping;
        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            topping = new List<Topping>();
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public IReadOnlyList<Topping> Toppings => this.topping;
       
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value)
                || value.Length < 0 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public void AddTopping(Topping curenttopping)
        {
            if (Toppings.Count==10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            topping.Add(curenttopping);
        }

        public double CalculateAllCalories()
        {
            double allSum = this.Dough.Calories + topping.Sum(x => x.Calories);
            return allSum;
        }
        // sum all calories
    }
}
