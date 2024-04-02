using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class ComplexCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"ComplexCommand, {args[0]}";
        }
    }
}
