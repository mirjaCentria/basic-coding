namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;

  public class SaveableDictionary 
  {
    List<KeyValuePair<string, string> > words;
    KeyValuePair<string, string> kvp;
    string file;

    public SaveableDictionary() 
    {
      this.words = new List<KeyValuePair<string, string> >();
    }

    public SaveableDictionary(string file) : this()
    {      
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      foreach(KeyValuePair<string, string> kvp in this.words)
      {
        if((kvp.Key == word) || (kvp.Value == word) )
        {   
          goto End;     
        }  
      }
      kvp = new KeyValuePair<string, string>(word, translation);
      words.Add(kvp);
      End:;
    }

    public bool Load()
    {
        try
        {   
            using (StreamReader sr = new StreamReader(this.file))
            {
                string line = "";
                
                while ((line = sr.ReadLine()) != null)
                {
                  if(line.Contains(':'))
                  {
                    string[] splittedline = line.Split(':');                 
                    this.Add(splittedline[0], splittedline[1]);  
                  }                 
                }
            }               
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
      return true;
    }

    public bool Save()
    {
      try
      {
        StreamWriter writer = new StreamWriter(this.file);
        
        foreach(KeyValuePair<string, string> kvp in this.words)
        {        
          writer.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
        }
        writer.Close();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      return true;
    }

    public string Translate(string word)
    {
      foreach(KeyValuePair<string,string> kvp in words)
      {
        if(kvp.Key == word) return kvp.Value;
        if(kvp.Value == word) return kvp.Key;  
      }      
      return null;
    }

    public bool Find(string word)
    {
      foreach(KeyValuePair<string, string> kvp in this.words)
      {
        if((kvp.Key == word) || (kvp.Value == word) )
        {
          return true;
        }  
      }
      return false;
    }

    public void Delete(string word)
    {
      foreach(KeyValuePair<string, string> kvp in this.words)
      {
        if((kvp.Key == word) || (kvp.Value == word) )
        {
          words.Remove(kvp);
          goto End;
        }  
      }
      End:;

    }

    public void Print()
    {
      foreach(KeyValuePair<string, string> kvp in this.words)
      {
        System.Console.WriteLine("{0} {1}",kvp.Key, kvp.Value);
      } 
    }
  }
}