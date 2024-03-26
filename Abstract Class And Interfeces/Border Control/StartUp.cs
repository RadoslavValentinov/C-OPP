using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            IWhoIAm peotrsonOrrob = null;
            List<IWhoIAm> persons = new List<IWhoIAm>();

            while (input != "End")
            {
                string[] splited = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splited.Length==3)
                {
                    string name = splited[0];
                    int age = int.Parse(splited[1]);
                    string id = splited[2];
                    peotrsonOrrob = new Citizens(name,age,id);
                    persons.Add(peotrsonOrrob);
                }
                else if (splited.Length==2)
                {
                    string model = splited[0];
                    string id = splited[1];
                    peotrsonOrrob = new Robots(model,id);
                    persons.Add(peotrsonOrrob);
                }
                input = Console.ReadLine();
            }

            string lastdigitId = Console.ReadLine();

            foreach (var who in persons)
            {
                if (who.Id.EndsWith(lastdigitId))
                {
                    Console.WriteLine(who.Id);
                }
            }
        }
    }
}
