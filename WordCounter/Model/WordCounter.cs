using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordFrequencyCounter
  {
    private string _capturedWord;
    private string _capturedSentence;

    public WordFrequencyCounter (string word, string sentence)
    {
      _capturedWord = word;
      _capturedSentence = sentence;
    }
    public string ReturnString()
    {
      string compareString = _capturedWord.ToLower();;
      return compareString;
    }
    public string ReturnSentence()
    {
      string compareSentence = _capturedSentence.ToLower();
      return compareSentence;
    }
    public string[] SplitSentence(char[] splitRules)
    {
      string userSentence = _capturedSentence;
      string[] splitArr = userSentence.Split(splitRules);
      return splitArr;
    }
    public string LetterCounter(string wordToBeCounted, string sentenceToBeSplit)
    {
      string[] splitArr = sentenceToBeSplit.Split(' ');
      int counter = 0;
      for (int i = 0; i < splitArr.Length; i++)
      {
        if (splitArr[i] == wordToBeCounted)
        {
          counter++;
        }
      }
      return counter;
    }
    public int WordCounter()
    {
      string wordToBeCounted = ReturnString();
      string sentenceToBeSplit = ReturnSentence();
      char[] splitRules = {' ',',','.','!','?'};
      string[] splitArr = SplitSentence(splitRules);
      int counter = LetterCounter(wordToBeCounted, sentenceToBeSplit);
      return counter;
    }
    // public string ToLowerCase()
    // {
    //   string wordToBeCounted = _capturedWord.ToLower();
    //   return wordToBeCounted;
    // }
    // public int DelimiterSplit()
    // {
    //   string wordToBeCounted = _capturedWord.ToLower();
    //   string sentenceToBeSplit = _capturedSentence.ToLower();
    //   char[] splitRules = {' ',',','.'};
    //   string[] splitArr = sentenceToBeSplit.Split(splitRules);
    //   int counter = 0;
    //   for (int i = 0; i < splitArr.Length; i++)
    //   if (splitArr[i] == wordToBeCounted)
    //   {
    //     counter++;
    //   }
    //   return counter;
    // }
  }
}
