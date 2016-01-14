using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public WordFrequencyAnalyzer()
        {

        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            //see how many matches we get for 'word' within given 'text'
            Regex wordRegex = new Regex(word, RegexOptions.IgnoreCase);
            var matches = wordRegex.Matches(text); 
            return matches.Count;
        }

        public int CalculateHighestFrequency(string text)
        {
            return 0;
        }

        public IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            return null;
        }
    }
}
