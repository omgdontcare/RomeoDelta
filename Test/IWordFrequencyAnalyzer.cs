using System.Collections.Generic;

namespace Test
{
    public interface IWordFrequencyAnalyzer
    {
        /// <summary>
        /// Should return the highest frequency in the text (several words might actually have this frequency)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        int CalculateHighestFrequency(string text);

        /// <summary>
        /// CalculateFrequencyForWord should return the frequency of the specified word
        /// </summary>
        /// <param name="text"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        int CalculateFrequencyForWord(string text, string word);

        /// <summary>
        /// Should return a list of the most frequent „n‟ words in the input text, all the words returned in lower case. 
        /// If several words have the same frequency, this method should return them in ascendant alphabetical order 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        IList<IWordFrequency> CalculateMostFrequentNWords(string text, int n);
    }
}
