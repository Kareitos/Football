using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201561036
{
    public class Team
    {
        public string Name { get; set; }
        public Coach Coach { get; set; }
        private List<Football_Player> players { get; set; }

        public List<Football_Player> Players
        {
            get { return players; }

            set 
            {
                if (value.Count < 11 && value.Count > 22)
                {
                    throw new ArgumentException("Players must be at least 11 and at most 22!");
                }
                players = value;
            }
        }
        public double AverageAge()
        { 
            int sumAge = 0;
            
            foreach(var player in Players)
            {
               sumAge+= player.Age;
            }

            return sumAge / Players.Count;
        }
        public Team()
        { 
          Players=new List<Football_Player>();
        }
    }
}
