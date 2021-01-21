using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGame
{
    class Stats
    {
        public int Total { get; set; }

        public int Missed { get; set; }

        public int Correct { get; set; }

        public int Accuracy { get; set; }

        public void Update(bool isCorrectKey)
        {
            Total++;

            if (!isCorrectKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }
}
