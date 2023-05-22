using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201561036
{
    public class Football_Player:Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public Football_Player(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
