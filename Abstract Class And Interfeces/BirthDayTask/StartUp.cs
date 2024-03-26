using System;
using System.Collections.Generic;
using BirthdayCelebrations;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            IWhoIAm peotrsonOrrob = null;
            IBirthsDay day= null;
            List<IWhoIAm> persons = new List<IWhoIAm>();

            List<IBirthsDay> birthdays = new List<IBirthsDay>();

            while (input != "End")
            {
                string[] splited = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comand = splited[0];
                if (comand== "Citizen")
                {
                    string name = splited[1];
                    int age = int.Parse(splited[2]);
                    string id = splited[3];
                    string birthday = splited[4];
                    peotrsonOrrob = new Citizens(name,age,id,birthday);
                    persons.Add(peotrsonOrrob);
                    day = new Citizens(name,age,id, birthday);
                    birthdays.Add(day);
                }
                else if (comand=="Robot")
                {
                    string model = splited[1];
                    string id = splited[2];
                    peotrsonOrrob = new Robots(model,id);
                    persons.Add(peotrsonOrrob);
                }
                else if (comand== "Pet")
                {
                    string name = splited[1];
                    string birthday = splited[2];
                    peotrsonOrrob = new Pet(name,birthday);
                    persons.Add(peotrsonOrrob);
                    day = new Pet(name,birthday);
                    birthdays.Add(day);
                }
                input = Console.ReadLine();
            }

            string lastdigitId = Console.ReadLine();

            foreach (var days in birthdays)
            {
                if (days.Birthday.EndsWith(lastdigitId))
                {
                    Console.WriteLine(days.Birthday);
                }
            }
        }
    }
}
