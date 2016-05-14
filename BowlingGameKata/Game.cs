using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<List<int>> pins)
        {
            int score = 0;
            for (int i = 0; i < 10; ++i )
            {
                if (IsStrike(pins[i], i))
                    score += addNextScore(pins, i, 2);
                if (IsSpare(pins[i], i))
                    score += addNextScore(pins, i, 1);
                Console.WriteLine(score);
                score += addGameScore(pins[i]);
            }
            
            return score;
        }

        public static bool IsStrike(List<int> game, int gameIndex)
        {
            if (gameIndex == 10)
                return false;
            return game.Count == 1;
               
        }

        public static bool IsSpare(List<int> game, int gameIndex)
        {
            if (gameIndex == 10)
                return false;
            if (game.Count == 2)
                return (game[0] + game[1]) == 10;
            else
                return false;
        }

        public static int addNextScore(List<List<int>> pins, int index, int addNum)
        {
            int sum = 0;
            sum += pins[index + 1][0];
            if (pins[index + 1].Count == 1)
            {
                sum += pins[index + 2][0];
            }
            else if (pins[index + 1].Count == 2 && addNum == 2)
            {
                sum += pins[index + 1][1];
            }
            return sum;
        }

        public static int addGameScore(List<int> game)
        {
            int sum = 0;
            for (int i = 0; i < game.Count; ++i)
            {
                sum += game[i];
            }
            return sum;
        }
    }
}
