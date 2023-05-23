using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer player { get; set; }


        public Goal(int m, FootballPlayer p)
        {
            Minute = m;
            player = p;
        }
    };
}

