using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Football_2201561036
{
    public class Game
    {
        private Team team1;

        private Team team2;
        public Referee Referee { get; set; }
        public AssistantReferee1 AssistantReferee1 { get; set; }
        public AssistantReferee2 AssistantReferee2 { get; set; }
        public List<Goal> Goals { get; set; }
        public string Game_result { get; set; }
        public string Winner { get; set; }
      public Game(Team team1, Team team2, Referee referee, AssistantReferee1 assistantReferee1, AssistantReferee2 assistantReferee2, List<Goal> goals)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
            Goals = goals;
            GameResult();
        }

        public Team Team1
        {
            get { return team1; }

            set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("The team must consist of exactly 11 players!");
                }
                team1 = value;
            }
        }

        public Team Team2
        {
            get { return team2; }

            set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentException("The team must consist of exactly 11 players!");
                }
                team2 = value;
            }
        }

        public void GameResult()
        {
            int goalsTeam1 = 0;
            int goalsTeam2 = 0;
       
            foreach (Goal goal in Goals)
            {
                if (Team1.Players.Any(player => player.Name == goal.Player))
                {
                    goalsTeam1++;
                }
                else if (Team2.Players.Any(player => player.Name == goal.Player))
                {
                    goalsTeam2++;
                }
            }

            if (goalsTeam1 > goalsTeam2)
            {
                Winner = team1.Name;
            }
            else if (goalsTeam2 > goalsTeam1)
            {
                Winner = team2.Name;
            }
            else
            {
                Winner = "X";
            }

            Game_result = $"{goalsTeam1}:{goalsTeam2}";


        }


    }
}
