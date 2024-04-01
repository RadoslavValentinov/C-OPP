using System;

namespace AuthorProblem
{
    [Author("Niki")]
    public class StartUp
    {
        [Author("Radi")]
        public static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
