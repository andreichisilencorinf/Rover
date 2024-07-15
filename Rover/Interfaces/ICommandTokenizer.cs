using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMission.Enums;

namespace MarsMission.Interfaces
{
    internal interface ICommandTokenizer
    {
        IEnumerable<CommandType> GetCommands(string commands);
    }

    internal class CommandTokenizer : ICommandTokenizer
    {
        public IEnumerable<CommandType> GetCommands(string commands)
        {
            var commandsList = new List<CommandType>();

            foreach (char command in commands)
            {
                if (Enum.TryParse<CommandType>(command.ToString().ToUpper(), out var parsedCommand))
                {
                    commandsList.Add(parsedCommand);
                }
                else
                {
                    throw new ArgumentException($"Invalid command: {command}");
                }
            }

            return commandsList;
        }
    }
}
