using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Competition
    {
        public List<Sportsman> partisipants = new List<Sportsman>();

        public Competition(List<Sportsman> sp)
        {
            this.partisipants = sp;
        }


        public List<Sportsman> getWinner()
        {
            List<Sportsman> answer = new List<Sportsman>();
            int max = -1;

            for(int i = 0; i< partisipants.Count; ++i)
            {
                if(partisipants[i].score > max)
                {
                    max = partisipants[i].score;
                }
            }

            for(int i=0; i < partisipants.Count; ++i)
            {
                if(partisipants[i].score == max)
                {
                    answer.Add(partisipants[i]);
                }
            }

            return answer;
        }
    }
}
