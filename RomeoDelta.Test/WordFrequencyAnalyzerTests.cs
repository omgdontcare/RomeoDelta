using System.Collections.Generic;
using NUnit.Framework;
using Test;

namespace RomeoDelta.Test
{
    [TestFixture]
    public class WordFrequencyAnalyzerTests
    {
        private WordFrequencyAnalyzer _frequencyAnalyzer;

        [SetUp]
        public void Init()
        {
            _frequencyAnalyzer = new WordFrequencyAnalyzer(new TextParserUtility());
        }

        [Test]
        public void CalculateFrequencyForWord_WordIsInTextTwoTimes_ShouldBeTwo()
        {
            string text = "The sun shines over the lake";
            string word = "the";
            int wordFrequency = _frequencyAnalyzer.CalculateFrequencyForWord(text, word);

            Assert.IsTrue(wordFrequency == 2, "Expected result was 2.");
        }

        [Test]
        public void CalculateFrequencyForWord_WordIsInTextOneTime_ShouldBeOne()
        {
            string text = "The sun shines over the lake";
            string word = "sun";
            int wordFrequency = _frequencyAnalyzer.CalculateFrequencyForWord(text, word);

            Assert.IsTrue(wordFrequency == 1, "Expected result was 1.");
        }

        [Test]
        public void CalculateFrequencyForWord_WordDoesntBelongToText_ShouldBeZero()
        {
            string text = "The sun shines over the lake";
            string word = "who";
            int wordFrequency = _frequencyAnalyzer.CalculateFrequencyForWord(text, word);

            Assert.IsTrue(wordFrequency == 0, "Expected result was 0.");
        }

        [Test]
        public void CalculateFrequencyForWord_SentenceHasDelimitersAndPunctuation_ShouldBeTwo()
        {
            string text = "Comparing this year's iPhone and this year's Nexus phone isn't usually all that interesting, because Google's partnerships " +
                          "with hardware partners are usually derived from an existing popular phone and so we've usually already seen what the compare will look like [...].";
            string word = "phone";
            int wordFrequency = _frequencyAnalyzer.CalculateFrequencyForWord(text, word);

            Assert.IsTrue(wordFrequency == 2, "Expected result was 2.");
        }

        [Test]
        public void CalculateHighestFrequency_SentenceIsMadeOutOfTheSameWord_ShouldBeNumberOfWords()
        {
            string text = "Why Why why wHy why. why! why why: whY";
            int highestFrequency = _frequencyAnalyzer.CalculateHighestFrequency(text);

            Assert.IsTrue(highestFrequency == 9, "Expected result was 9.");
        }

        [Test]
        public void CalculateHighestFrequency_TextContainsTwoWordsWithTheSameFrequency_ShouldBeOneOfTheseWords()
        {
            string text = "The Goldman Sachs Group, Inc. is an American multinational investment banking firm that engages in global investment banking, " +
                          "securities and other financial services primarily with institutional clients.";
            int highestFrequency = _frequencyAnalyzer.CalculateHighestFrequency(text);

            Assert.IsTrue(highestFrequency == 2, "Expected result was 2.");
        }

        [Test]
        public void CalculateMostFrequentNWords_TextContainsTwoWordsWithHighestFrequency_ShouldReturnFirstWordInAlphabeticalOrder()
        {
            string text = "Stephen Edwin King was born the second son of Donald and Nellie Ruth Pillsbury King. " +
                          "After his father left them when Stephen was two, he and his older brother, David, were raised by his mother. I'm a king.";

            IList<IWordFrequency> actualResult = _frequencyAnalyzer.CalculateMostFrequentNWords(text, 1);
            IList<IWordFrequency> expectedResult = new List<IWordFrequency>() { new WordFrequency("his", 3)};

            CollectionAssert.AreEqual(actualResult, expectedResult, "Expected 1 word with the highest frequency");
        }
    }
}
