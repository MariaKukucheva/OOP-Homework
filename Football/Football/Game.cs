using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public List<Referee> Referee { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }

        public Game(Team one, Team two, List<Referee> r)
        {
            Random rand = new Random();
            int goals = rand.Next(1, 4);//за да влезе в цикъла започва от 1
            int team, player, min;
            int t1goals = 0;
            int t2goals = 0;
            for (int i = 0; i < goals; i++)
            {
                team = rand.Next(1, 3);
                if (team == 1)
                {
                    player = rand.Next(1, 12);
                    min = rand.Next(1, 91);
                    Goal goal = new Goal(min, one.Players[player]);
                    t1goals++;
                }
                else
                {
                    player = rand.Next(1, 12);
                    min = rand.Next(1, 91);
                    Goal goal = new Goal(min, two.Players[player]);
                    t2goals++;
                }
            
                if (t1goals > t2goals)
                {
                    Console.WriteLine($"Team One - {t1goals}  :  Team Two - {t2goals}");
                    Console.WriteLine($"In {min} minutes a goal was scored by a player with No: {player}");
                    Console.WriteLine(" ");
                }
                else if (t2goals > t1goals)
                {
                    Console.WriteLine($"Team Two - {t2goals}  :  Team One - {t1goals}");
                    Console.WriteLine($"In {min} minutes a goal was scored by a player with No: {player}");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine($"Draw -> {t2goals}  :  {t1goals}");
                    Console.WriteLine($"In {min} minutes a goal was scored by a player with No: {player}");
                    Console.WriteLine("");
                }

        }
            Console.WriteLine("---------- Result ----------");
            if (t1goals > t2goals)
            {
                Console.WriteLine($"Team One Win -> {t1goals} : {t2goals}");
            }
            else if (t2goals > t1goals)
            {

                Console.WriteLine($"Team Two Win -> {t2goals} : {t1goals}");
            }
            else
            {

                Console.WriteLine($"Draw -> {t2goals} : {t1goals}");
            }
        }
    }
}
