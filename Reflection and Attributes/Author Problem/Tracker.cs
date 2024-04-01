using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var typr = typeof(StartUp);

            var metod = typr.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var info in metod)
            {
                if (info.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var atribute = info.GetCustomAttributes(false);

                    foreach (AuthorAttribute atr in atribute)
                    {
                        Console.WriteLine($"{info.Name} is written by {atr.Name}");
                    }
                }
            }
        }
    }
}
