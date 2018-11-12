using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Question
    {
        string Riddle;
        List<string> Answer = new List<string>();
        bool TrueOrFalse;

        public Question()
        {
        }
        public Question(string value)
        {
            var seperateRiddle = value.Split(':');
            int counter = 0;
            foreach (var item in seperateRiddle)
            {
                if (counter == 0)
                {
                    this.Riddle = item;
                    counter++;
                }
                else
                {
                    this.Answer.Add(item);
                    counter++;
                }
            }
        }
        public string getRiddle()
        {
            return this.Riddle;
        }
        public List<string> GetAnswer()
        {
            return this.Answer;
        }

        public void setTrueOrFalse(char value)
        {
            if (value == 't')
            {
                this.TrueOrFalse = true;
            }
            else
            {
                this.TrueOrFalse = false;
            }
        }
        public bool getTrueOrFalse()
        {
            return this.TrueOrFalse;
        }
    }
}
