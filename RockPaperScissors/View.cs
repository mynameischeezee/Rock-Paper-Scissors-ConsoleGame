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
            RandomKeyGenerator keyGenerator = new RandomKeyGenerator();
            HMACGenerator hMACGenerator = new HMACGenerator();
            IValidator validator = new Validator();
            MessageProvider messageProvider = new MessageProvider();
            if (validator.Validate(args))
            {
                var key = keyGenerator.Generate();
                var a = validator.Validate(args);
                Game game = new Game(args);
                var pcmove = game.GenerateMove();
                Console.WriteLine($"[~]HMAC: {hMACGenerator.Generate(args[pcmove], key)}");
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
                        Console.WriteLine(game.MakeMove(choice, pcmove));
                        Console.WriteLine($"[~]HMAC key is: {key}");
                        break;
                    }
                    else if (input != "?")
                    {
                        Console.WriteLine(messageProvider.ErrorMessage());
                    }

                }
            }
            else
            {
                Console.WriteLine(messageProvider.ErrorMessage());
            }
            

        }
    }
}
