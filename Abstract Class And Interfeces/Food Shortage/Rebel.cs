using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel:IBuyer_
    {

        public Rebel(string name, int age, string groups)
        {
            Name = name;
            Age = age;
            Group = groups;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Group  { get; set; }
        public void BuyFood()
        {
            this.Food += 5;
        }

        public int Food { get; set; }
        
    }
}
