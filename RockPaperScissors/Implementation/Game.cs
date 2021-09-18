using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        private string[] arguments;
        public int[,] gamerules { get; private set; }
        public string Winner { get; private set; }

        public Game(string[] arguments)
        {
            this.arguments = arguments;
            this.gamerules = GameRules.GenereteRules(new int[arguments.Length, arguments.Length]);
        }
        public string MakeMove(int move)
        {
            return "";
        }
        private string FinishGame()
        {
            return "";
        }
    }
}
