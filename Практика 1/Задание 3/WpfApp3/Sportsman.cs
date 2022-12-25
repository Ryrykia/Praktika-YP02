using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Sportsman
    {
        public string Name;
        public int score;

        public Sportsman() {
        }

        public Sportsman(string name, int score)
        {
            this.Name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
