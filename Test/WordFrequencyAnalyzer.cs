using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        private readonly ITextParserUtility _textParserUtility;

        public WordFrequencyAnalyzer(ITextParserUtility textParserUtility)
        {
            _textParserUtility = textParserUtility;
        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            return _textParserUtility.GetFrequencyForGivenWord(text, word);
        }

        public int CalculateHighestFrequency(string text)
        {
            var mostFrequentWord = _textParserUtility.GetMostFrequentNWords(text, 1).FirstOrDefault();
            return mostFrequentWord == null ? 0 : mostFrequentWord.Frequency;
        }

        public IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {
            return _textParserUtility.GetMostFrequentNWords(text, n);
        }
    }
}
