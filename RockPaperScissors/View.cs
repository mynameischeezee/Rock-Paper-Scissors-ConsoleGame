using System;
using System.Collections.Generic;
using AVS.CoreLib.PowerConsole;
using ConsoleTables;
using System.Linq;

namespace RockPaperScissors
{

    class View
    {
        static void Main(string[] args)
        {
            IValidator validator = new Validator();
            MessageProvider messageProvider = new MessageProvider();
            if (validator.Validate(args))
            {
                var a = validator.Validate(args);
                Game game = new Game(args);
                Console.WriteLine(messageProvider.StartMessage(args));
                while(true)
                {
                    Console.WriteLine("Chose your option: ");
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "0": Environment.Exit(0); break;
                        case "?": messageProvider.HelpMessage(game.gamerules, args).Write(); break;
                    }
                    int choice;
                    if (Int32.TryParse(input, out choice))
                    {
                        game.MakeMove(choice);
                        break;
                    }
                    Console.WriteLine(messageProvider.ErrorMessage());
                }
            }
            else
            {
                Console.WriteLine(messageProvider.ErrorMessage());
            }
            

        }
    }
}
