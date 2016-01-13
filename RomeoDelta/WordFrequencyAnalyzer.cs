using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return 0;
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
