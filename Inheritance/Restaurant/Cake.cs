using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.classes
{
    public class Cake : Dessert
    {
        private const double GramsCake = 250;
        private const decimal Price = 5;
        private const double Calories = 1000;

        public Cake(string name) 
            : base(name, Price, GramsCake,Calories)
        {
        }
    }
}
