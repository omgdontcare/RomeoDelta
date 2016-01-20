using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    public class TextParser : ITextParser
    {
        public IList<IWordFrequency> ParseText(string text)
        {
            var matchedWordsList =
                Regex.Matches(text, RegExPatternCollection.AnyWordPattern, RegexOptions.IgnoreCase)
                    .OfType<Match>()
                    .Select(x => x.Value.ToLower());

            //sort by frequency
            var wordsDictionary =
                matchedWordsList.GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());

            return wordsDictionary.Select(x => new WordFrequency(x.Key.ToLower(), x.Value)).ToList<IWordFrequency>();
        }
    }
}