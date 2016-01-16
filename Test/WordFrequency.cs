namespace Test
{
    public class WordFrequency : IWordFrequency
    {
        public WordFrequency(int frequency, string word)
        {
            Frequency = frequency;
            Word = word;
        }

        public int Frequency { get; }

        public string Word { get; }
    }
}
