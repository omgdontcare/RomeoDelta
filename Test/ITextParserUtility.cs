using System.Collections.Generic;

namespace Test
{
    public interface ITextParserUtility
    {
        IList<IWordFrequency> GetMostFrequentNWords(string text, int n);

        int GetFrequencyForGivenWord(string text, string word);
    }
}
