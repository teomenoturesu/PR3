using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Player
    {
        public string Name { get; set; }
        public ushort Score { get; set; }
        public bool Status { get; set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
            Status = false;
        }
    }
}
