using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class MessageProvider
    {
        public string ErrorMessage()
        {
            return "[X]Error. Invalid arguments given. Try one more time.";
        }
        public ConsoleTable HelpMessage(int[,] GameRules, string[] InputArgs)
        {
            return HelpTableGenerator.GenerateHelp(GameRules, InputArgs);
        }

        public string StartMessage(string[] InputArgs)
        {
            string outputMessage = "[i]Avalible Moves:";
            for (int i = 0; i < InputArgs.Length; ++i) { outputMessage += Environment.NewLine + $"{i + 1} - {InputArgs[i]}"; }
            outputMessage += Environment.NewLine + "0 - Exit."; outputMessage += Environment.NewLine + "? - Help.";
            return outputMessage;
        }
    }
}
