using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            var matches = Regex.Matches(text, word, RegexOptions.IgnoreCase); 
            return matches.Count;
        }

        public int CalculateHighestFrequency(string text)
        {
            //split text into words
            var matchedWords =
                Regex.Matches(text, @"((\b[^\s]+\b)((?<=\.\w).)?)", RegexOptions.IgnoreCase)
                    .OfType<Match>()
                    .Select(x => x.Value.ToLower());

            //sort by frequency
            var counts = matchedWords.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            //pick highest frequency
            return counts.OrderByDescending(x => x.Value).First().Value;
        }

        public IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            return null;
        }
    }
}
