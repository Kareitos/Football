using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201561036
{
    public class Goal
    {
        public int Minute { get; set; }
        public string Player { get; set; }
        public Goal(int minute,string player)
        {
            Minute = minute;
            Player = player;
        }

    }
}
