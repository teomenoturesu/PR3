using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Question
    {
        public string Vopros { get; set; }
        public string Answer { get; set; }
        public ushort Score { get; set; }
        public Question(string vopros, string answer, ushort score)
        {
            Vopros = vopros;
            Answer = answer;
            Score = score;
        }
    }
}
