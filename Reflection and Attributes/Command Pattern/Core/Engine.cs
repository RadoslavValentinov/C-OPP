using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreterer)
        {
            this.commandInterpreter = commandInterpreterer;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    string result = this.commandInterpreter.Read(input);

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
