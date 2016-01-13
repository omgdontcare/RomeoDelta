using NUnit.Framework;
using Test;

namespace RomeoDelta.Test
{
    [TestFixture]
    public class UnitTest1
    {
        private WordFrequencyAnalyzer frequencyAnalyzer;

        [SetUp]
        public void Init()
        {
            frequencyAnalyzer = new WordFrequencyAnalyzer();
        }

        [Test]
        public void TestMethod1()
        {
            string text = "The sun shines over the lake";
            string word = "the";
            int wordFrequency = frequencyAnalyzer.CalculateFrequencyForWord(text, word);

            Assert.IsTrue(wordFrequency == 2, "Expected result was 2.");
        }
    }
}
