namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;

  public class SaveableDictionary 
  {
    List<KeyValuePair<string, List<string>> > words;
    KeyValuePair<string, List<string>> kvp;
    List <string> list;
    string file;

    public SaveableDictionary() 
    {
      this.words = new List<KeyValuePair<string, List<string>> >();
    }

    public SaveableDictionary(string file) 
    {
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      list = new List<string>();
      list.Add(translation);
      kvp = new KeyValuePair<string, List<string>>(word, list);
      words.Add(kvp);
    }

    public bool Load()
    {
      return false;
    }

    public bool Save()
    {
      return false;
    }

    public string Translate(string word)
    {
      foreach(KeyValuePair<string,  List<string>> kvp in words)
      {
        if(kvp.Key == word) return kvp.Value[0];
        if(kvp.Value.Contains(word) ) return kvp.Key;
      }      
      return null;
    }

    public void Delete(string word)
    {
      foreach(KeyValuePair<string, List<string>> kvp in this.words)
      {
        if((kvp.Key == word)) 
        {
          words.Remove(kvp);
          goto End1;
        }  
      }
      End1:;

      foreach(KeyValuePair<string, List<string>> kvp in this.words)
      {
        if(kvp.Value.Contains(word)) 
        {
          kvp.Value.Remove(word);
          if(kvp.Value.Count == 0) words.Remove(kvp);
          goto End2;
        }  
      }

      End2:;
    }
  }
}