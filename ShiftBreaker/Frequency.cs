using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftBreaker
{
    public class Frequency
    {

       
        public Dictionary<string, int> WordCount(string[] words)
        {
            //loop through
            //check if dictionary Contains
            //if not, add, if it does, update value

            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if ((word != null) && (word != ""))
                {
                    if (!wordFreq.ContainsKey(word))
                    {
                        wordFreq[word] = 1;
                    }
                    else
                    {
                        wordFreq[word]++;
                    }
                }
            }

            return wordFreq;
        }


    }
}
