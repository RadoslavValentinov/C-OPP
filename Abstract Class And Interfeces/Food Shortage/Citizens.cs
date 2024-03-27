using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations;
using FoodShortage;

namespace BorderControl
{
    public class Citizens : IWhoIAm,IBirthsDay,IBuyer_
    {
        private string name;
        private int age;
        private string id;
        private string birthday;

        public Citizens(string name,int age,string id,string birhtday)
        {
            this.Name = name;
            Age = age;
            this.Id = id;
            this.Birthday = birhtday;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public int Food { get; set; }
        
    }
}
