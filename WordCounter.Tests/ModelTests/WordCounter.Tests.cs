using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordFrequencyCounterTest
  {

    [TestMethod]
    public void Constructor_CreatesInstanceOfWordFrequencyCounter_True()
    {
      WordFrequencyCounter newWord = new WordFrequencyCounter(" ", " ");
      Assert.AreEqual(typeof(WordFrequencyCounter), newWord.GetType());
    }

    [TestMethod]
    public void ReturnString_ReturnsAString_String()
    {
      string testLetter = "a";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", " ");
      string result = newTest.ReturnString();
      Assert.AreEqual(testLetter, result);
    }

    [TestMethod]
    public void ReturnSentence_ReturnASentence_String()
    {
      string testSentence = "Wow, what a task this is";
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", "Wow, what a task this is");
      string result = newTest.ReturnSentence();
      Assert.AreEqual(testSentence, result);
    }

    [TestMethod]
    public void SplitSentence_ReturnAListOfWordsInSentence_String()
    {
      string[] testArray = new string[] {"Hey", "now", "hey", "now"};
      WordFrequencyCounter newTest = new WordFrequencyCounter("a", "Hey now hey now");
      string[] result = newTest.SplitSentence();
      CollectionAssert.AreEqual(testArray, result);
    }

    [TestMethod]
    public void LetterCounter_CountAllInstancesOfASingleLetterInASentence_String()
    {
      string expectedAnswer = "4";
      WordFrequencyCounter newTest = new WordFrequencyCounter ("a", "Look at a a a word that a user can enter");
      string result = newTest.LetterCounter();
      Console.WriteLine("-------------------------This is the expected count value taken from the LetterCounter method: " + result);
      Assert.AreEqual(expectedAnswer, result);
    }

    [TestMethod]
    public void WordCounter_CountsAllInstancesOfASingleWordInASentence_Int()
    {
      int expectedAnswer = 4;
      WordFrequencyCounter newTest = new WordFrequencyCounter ("Hello", "Hello, hello. HeLLo, the cheery man saying !Hello helloseph");
      int result = newTest.WordCounter();
      Assert.AreEqual(expectedAnswer, result);
    }


    [TestMethod]
    public void ToLowerCase_ReturnsStringsLowerCased_String()
    {
      string expectedAnswer = "hello";
      WordFrequencyCounter newTest = new WordFrequencyCounter ("HELLO", " ");
      string result = newTest.ToLowerCase();
      Console.WriteLine("___________________Lower cased word____________ " + result);
      Assert.AreEqual(expectedAnswer, result);
    }
    [TestMethod]
    public void DelimiterSplit_SplitStringUsingDelimitersToAccountForPuncuation_Int()
    {
      int expectedAnswer = 3;
      WordFrequencyCounter newTest = new WordFrequencyCounter ("hello", "Hello, my name is Chris. I like hello, to say ,hello.");
      int result = newTest.DelimiterSplit();
      Assert.AreEqual(expectedAnswer, result);
    }

  }
}
