using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Football_2201561036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football_Player p1 = new Striker("Diogo Jota", 26, 20, 178);
            Football_Player p2 = new Striker("Cody Gapko", 24, 18, 193);
            Football_Player p3 = new Striker("Mohamed Salah", 30, 11, 175);

            Football_Player p4 = new Midfielder("Jordan Henderson", 32, 14, 182);
            Football_Player p5 = new Midfielder("Fabinho", 27, 3, 188);
            Football_Player p6 = new Midfielder("Harvey Elliott", 20, 19, 170);

            Football_Player p7 = new Defender("Andrew Robertson", 29, 26, 178);
            Football_Player p8 = new Defender("Virgil van Dijk", 30, 4, 193);
            Football_Player p9 = new Defender("Ibrahima Konate", 23, 5, 178);
            Football_Player p10 = new Defender("Trent Alexander-Arnold", 23, 66, 175);

            Football_Player p11 = new Goalkeeper ("Alisson Becker", 29, 1, 191 );

            Coach coach1 = new Coach("Jurgen Klopp", 55);

            List<Football_Player> Liverpool = new List<Football_Player>();

            Liverpool.Add(p1);
            Liverpool.Add(p2);
            Liverpool.Add(p3);
            Liverpool.Add(p4);
            Liverpool.Add(p5);
            Liverpool.Add(p6);
            Liverpool.Add(p7);
            Liverpool.Add(p8);
            Liverpool.Add(p9);
            Liverpool.Add(p10);
            Liverpool.Add(p11);

            Team team1 = new Team {Name="Liverpool FC", Coach = coach1, Players = Liverpool };

            //--------------------------------------------------------------------------------------------------------------------
            Football_Player p12 = new Striker("Ivan Ivanov", 26, 20, 178);
            Football_Player p13 = new Striker("Georgi Ivanov", 26, 18, 193);
            Football_Player p14 = new Striker("Kiril Despodov", 34, 11, 175);

            Football_Player p15 = new Midfielder("Krasimir Tenev", 32, 14, 182);
            Football_Player p16 = new Midfielder("Ivailo Popov", 21, 3, 188);
            Football_Player p17 = new Midfielder("Spas Delev", 28, 19, 170);

            Football_Player p18 = new Defender ( "Todor Nedev", 25, 26, 178 );
            Football_Player p19 = new Defender ("Kaloyan Hristov", 37, 4, 193);
            Football_Player p20 = new Defender ("Boyan Uzunov", 33, 5, 178);
            Football_Player p21 = new Defender ("Angel Momov", 34, 66, 175);

            Football_Player p22 = new Goalkeeper ("Petar Marinov", 38, 1, 191);

            Coach coach2 = new Coach ( "Georgi Dermendzhiev", 55 );

            List<Football_Player> Bulgarians = new List<Football_Player>();

            Bulgarians.Add(p12);
            Bulgarians.Add(p13);
            Bulgarians.Add(p14);
            Bulgarians.Add(p15);
            Bulgarians.Add(p16);
            Bulgarians.Add(p17);
            Bulgarians.Add(p18);
            Bulgarians.Add(p19);
            Bulgarians.Add(p20);
            Bulgarians.Add(p21);
            Bulgarians.Add(p22);

            Team team2 = new Team { Name = "FC Ludogoretz" ,Coach = coach2, Players = Bulgarians };

            //--------------------------------------------------------------------------------------------------------------------

            Referee referee = new Referee("Geogi Kabakov", 37);
            AssistantReferee1 assref1 = new AssistantReferee1 ("Ivailo Dimitrov", 30);
            AssistantReferee2 assref2 = new AssistantReferee2 ("Ivan Todorv", 35);

            List<Goal> goals = new List<Goal>();

            Goal g1 = new Goal(40,p3.Name);
            Goal g2 = new Goal(54,p3.Name);
            Goal g3 = new Goal(58, p4.Name);
            Goal g4 = new Goal(60, p15.Name);
            Goal g5 = new Goal(66, p16.Name);
            Goal g6 = new Goal(88, p13.Name);
            Goal g7 = new Goal(88, p2.Name);
            Goal g8 = new Goal(88, p8.Name);

            goals.Add(g1);
            goals.Add(g2);
            goals.Add(g3);
            goals.Add(g4);
            goals.Add(g5);
            goals.Add(g6);
            goals.Add(g7);
            goals.Add(g8);



            Game MatchOfTheDay = new Game(team1, team2,referee,assref1,assref2,goals);
         

            //--------------------------------------------------------------------------------------------------------------------
            Console.WriteLine($"The average age of the players in {team1.Name} is :{team1.AverageAge()}");
            Console.WriteLine($"The average age of the players in {team2.Name} is :{team2.AverageAge()}");
            Console.WriteLine();

            foreach (Goal goal in goals)
            {
                Console.WriteLine($"Min: {goal.Minute}, Player : {goal.Player}");
            }

            Console.WriteLine();
            Console.WriteLine($"Match result between {team1.Name} - {team2.Name}:{MatchOfTheDay.Game_result}");
            Console.WriteLine($"Winner is :{MatchOfTheDay.Winner}!!!!!!");   

        }
    }
}
