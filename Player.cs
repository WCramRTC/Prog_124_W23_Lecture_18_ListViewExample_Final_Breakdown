using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_18_ListViewExample_Final_Breakdown
{
    public class Player
    {

        string _name;
        int _hitPoints;
        string _job;

        public Player(string name, int hitPoints, string job)
        {
            _name = name;
            _hitPoints = hitPoints;
            _job = job;
        }

        public string Name { get => _name; set => _name = value; }
        public int HitPoints { get => _hitPoints; set => _hitPoints = value; }
        public string Job { get => _job; set => _job = value; }
    }
}
