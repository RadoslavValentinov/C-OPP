using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("Radi");
            list.Add("Maya");
            list.Add("lelia");
            Console.WriteLine(list.RandomString());
            
        }
    }
}
