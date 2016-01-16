using System;
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
            var matches = Regex.Matches(text, String.Format(RegExPatterns.WordMatchPatternFormat, word), RegexOptions.IgnoreCase); 
            return matches.Count;
        }

        public int CalculateHighestFrequency(string text)
        {
            //TODO move outside class; reuse for CalculateMostFrequentNWords

            //split text into words
            var matchedWordsList =
                Regex.Matches(text, RegExPatterns.AnyWordPattern, RegexOptions.IgnoreCase)
                    .OfType<Match>()
                    .Select(x => x.Value.ToLower());

            //sort by frequency
            var counts = matchedWordsList.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            //pick highest frequency
            return counts.OrderByDescending(x => x.Value).First().Value;
        }

        public IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            var result = new List<IWordFrequency>();

            return result;
        }
    }
}
