using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set;}

        public List<FootballPlayer> Players = new List<FootballPlayer>();


        public Team(Coach c, List<FootballPlayer> p)
        {

            Coach = c;
            Players = p;
        }
        public double AveragePlayerAge
        {
            get
            {
                double sum = 0;
                foreach (FootballPlayer player in Players)
                {
                    sum += player.Age;
                }

                return sum / Players.Count;
            }
        }
    }

}
