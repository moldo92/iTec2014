using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class VotedCategories
    {
        public int Points { get; set; }
        public int Votes { get; set; }
        public string Name { get; set; }

        public VotedCategories(int points, int votes, string name)
        {
            Points = points;
            Votes = votes;
            Name = name;
        }

    }
}
