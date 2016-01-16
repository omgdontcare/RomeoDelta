using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    public class TextParserUtility : ITextParserUtility
    {
        private IList<IWordFrequency> ParseText(string text)
        {
            var matchedWordsList =
               Regex.Matches(text, RegExPatterns.AnyWordPattern, RegexOptions.IgnoreCase)
                   .OfType<Match>()
                   .Select(x => x.Value.ToLower());

            //sort by frequency
            var wordsDictionary =
                matchedWordsList.GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());

            return wordsDictionary.Select(x => new WordFrequency(x.Key.ToLower(), x.Value)).ToList<IWordFrequency>();
        }

        public IList<IWordFrequency> GetMostFrequentNWords(string text, int n)
        {
            var wordFrequencyList = ParseText(text);
            var mostFrequentNWordsList = wordFrequencyList.OrderByDescending(x => x.Frequency).Take(n).ToList();

            return mostFrequentNWordsList;
        }
    }
}
