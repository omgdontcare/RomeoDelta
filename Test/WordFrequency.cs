namespace Test
{
    public class WordFrequency : IWordFrequency
    {
        public WordFrequency(string word, int frequency)
        {
            Frequency = frequency;
            Word = word.ToLower();
        }

        public int Frequency { get; }

        public string Word { get; }
    }
}
