using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        private readonly ITextParser _textParser;

        public WordFrequencyAnalyzer(ITextParser textParser)
        {
            _textParser = textParser;
        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            var wordsList = _textParser.ParseText(text);
            var wordFrequencyItem = wordsList.FirstOrDefault(x=>x.Word == word);
            return wordFrequencyItem?.Frequency ?? 0;
        }

        public int CalculateHighestFrequency(string text)
        {
            return CalculateMostFrequentNWords(text, 1).FirstOrDefault()?.Frequency ?? 0;
        }

        public IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            var wordsList = _textParser.ParseText(text);
            var wordFrequencyList = wordsList.OrderByDescending(x => x.Frequency).ThenBy(x => x.Word).Take(n).ToList();

            return wordFrequencyList;
        }
        
    }
}
