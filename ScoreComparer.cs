using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___IComparable___Sorting
{
    public class ScoreComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.Score.CompareTo(y.Score);
        }
    }
}
