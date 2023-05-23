using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Football
{
    class Program
    {
        
        static void Main()
        {
            List<FootballPlayer> p1 = new List<FootballPlayer>();

            Goalkeeper gk = new Goalkeeper("Anton Atanasov", 29, 1, 1.72);
            p1.Add(gk);

            Defender d1 = new Defender("Ivan Georgiev", 31, 2, 1.80);
            p1.Add(d1);
            Defender d2 = new Defender("Petar Plamenov", 30, 3, 1.77);
            p1.Add(d2);
            Defender d3 = new Defender("Kostadin Petrov", 28, 4, 1.75);
            p1.Add(d3);

            Midfield m1 = new Midfield("Hristo ivanov", 23, 5, 1.66);
            p1.Add(m1);
            Midfield m2 = new Midfield("Plamen Plamenov", 29, 6, 1.72);
            p1.Add(m2);
            Midfield m3 = new Midfield("Marin Kostadinov", 22, 7, 1.69);
            p1.Add(m3);
            Midfield m4 = new Midfield("Plamen Marinov", 30, 8, 1.82);
            p1.Add(m4);

            Striker s1 = new Striker("Ivailo Hristov", 31, 9 , 1.83);
            p1.Add(s1);
            Striker s2 = new Striker("Boyan Hristov", 31, 10, 1.93);
            p1.Add(s2);
            Striker s3 = new Striker("Anton Boyanov", 31, 11, 1.89);
            p1.Add(s3);


            List<FootballPlayer> p2 = new List<FootballPlayer>();

            Goalkeeper gk2 = new Goalkeeper("Anton Antonov", 29, 1, 1.72);
            p2.Add(gk2);

            Defender d11 = new Defender("Hristo Hristov", 26, 2, 1.80);
            p2.Add(d11);
            Defender d22 = new Defender("Ivailo Ivailov", 30, 3, 1.77);
            p2.Add(d22);
            Defender d33 = new Defender("Mihail Mihailov", 28, 4, 1.75);
            p2.Add(d33);

            Midfield m11 = new Midfield("Hristo ivanov", 23, 5, 1.66);
            p2.Add(m11);
            Midfield m22 = new Midfield("Marin Marinov", 28, 6, 1.72);
            p2.Add(m22);
            Midfield m33 = new Midfield("Kostadin Kostadinov", 21, 7, 1.69);
            p2.Add(m33);
            Midfield m44 = new Midfield("Kaloqn Kaloqnov", 30, 8, 1.82);
            p2.Add(m44);

            Striker s11 = new Striker("Petar Petrov", 22, 9, 1.86);
            p2.Add(s11);
            Striker s22 = new Striker("Georgi Georgiev", 31, 10, 1.73);
            p2.Add(s22);
            Striker s33 = new Striker("Ivan Ivanov", 25, 11, 1.83);
            p2.Add(s33);


            List<Referee> r = new List<Referee>();
            Referee r1 = new Referee("Petar Angelov", 44);
            r.Add(r1);
            Referee r2 = new Referee("Georgi Ivanoov", 50);
            r.Add(r2);
            Referee r3 = new Referee("Marin Georgiev", 48);
            r.Add(r3);

            Coach c1 = new Coach("Kaloyan Yavorov", 52);
            Coach c2 = new Coach("Iliyan Pavlov", 55);

            Team one = new Team(c1,p1);
            Team two = new Team(c2, p2);

            Game game = new Game(one, two, r);
         
        }
    }
}