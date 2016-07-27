using System.Collections.Generic;
using Xunit;
using System;

namespace WordCounter
{
  public class RepeatCounterTest
  {
      [Fact]
      public void Test1_RepeatCounterGetA_true()
      {
        string word = "a";
        RepeatCounter checkNewWord = new RepeatCounter(word,"");
        string checkWord = checkNewWord.GetWord();

        Assert.Equal(word, checkWord);
      }
