using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class BeepCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Beep, {args[0]}";
        }
    }
}
