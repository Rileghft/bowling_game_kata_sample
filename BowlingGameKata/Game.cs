using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i < 10 ;i++ )
            {
           
                IsStrike(pins,2*i,ref score);
                IsSpare(pins, 2 * i, ref score);
                //else if(pins[2*i]+pins[2*i+1]==10)
                score += pins[2*i]+pins[2*i+1];
            }
            
            return score;
        }

        public static void IsStrike(List<int> pins, int index,ref int score)
        { 
            if(pins[index]==10)
            {
                int nextindex=(index%2==0) ? index+2 : index+1;
                score += pins[nextindex] + pins[nextindex + 1];
            }
               
        }

        public static void IsSpare(List<int> pins, int index, ref int score)
        {
            int FirstPin = pins[index];
            int SecondPin = pins[index + 1];
            if (FirstPin != 10 && SecondPin != 10 &&
                FirstPin + SecondPin == 10)
            {
                int nextindex = (index % 2 == 0) ? index + 2 : index + 1;
                score += pins[nextindex];
            }

        }
    }
}
