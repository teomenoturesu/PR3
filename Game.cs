using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PR3
{
    internal class Game
    {

        public List<Player> Players { get; set; }
        public static byte AmountOfPlayers {get;set;}
        public Game(byte amountofplayers, List<Player> players)
        {
            for (byte i = 1; i <= amountofplayers; i++)
            {
                 players.Add(new Player("Player" + i));
            }
            Players = players;
        }
        public void Start()
        {
            Players[0].Status = true;
        }
    }
}
