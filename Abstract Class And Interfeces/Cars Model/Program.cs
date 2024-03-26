using System;
using System.Threading.Channels;

namespace Cars
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICar seat = new Seat("BMW","Black");
            ICar teslaR = new Tesla("Model 3", "Red", 80);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(teslaR.ToString());
        }
    }
}
