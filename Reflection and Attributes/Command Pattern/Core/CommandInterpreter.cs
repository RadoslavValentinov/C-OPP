using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        public string Read(string args)
        {
            string[] inputinfo = args.Split();

            string comandName = inputinfo[0] + "Command";
            string[] param = inputinfo.Skip(1).ToArray();
            string result = String.Empty;


            Type Type = Assembly.GetCallingAssembly().GetTypes().Where(x => x.Name == comandName).FirstOrDefault();
           
            if (Type==null)
            {
                throw new InvalidOperationException("Invalid command");
            }
            ICommand command = Activator.CreateInstance(Type) as ICommand;

            result = command.Execute(param);
            return result;
        }
    }
}
