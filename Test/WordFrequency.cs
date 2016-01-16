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

        public override bool Equals(object obj)
        {
            var toCompareObj = (WordFrequency) obj;
            return Frequency == toCompareObj.Frequency && Word == toCompareObj.Word;
        }
    }
}
