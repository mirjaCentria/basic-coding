using System;
using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    protected Dictionary<string, List<String> > words;

    public DictionaryOfManyTranslations()
    {
      List<string> list = new List<string>();
      words = new Dictionary<string, List<string>>();

    }
    public void Add(string word, string translation)
    {
 
      if(words.ContainsKey(word))
      {
        words[word].Add(translation);
      } else 
      {
        List<string> trs = new List<string>();
        trs.Add(translation);         
        this.words.Add(word, trs);
      }
    }

    public List<string> Translate(string word)
    {
      if(words.ContainsKey(word))
        return new List<string>(words[word]);
      else return new List<string>();
    }    public void Remove(string word)
    {
      if(words.ContainsKey(word))
        words.Remove(word);
    }
  }
}