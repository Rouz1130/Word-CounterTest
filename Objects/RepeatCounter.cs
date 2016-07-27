using System;
using System.Collections.Generic;

namespace WordCounterC
{
  public class RepeatCounter
{
    private string _word;
    private string _sentence;
    // private static List<RepeatCounter> _instances = new List<RepeatCounter> {}
    // might have to put in a private in RepeatCounter?? try it out
    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }
