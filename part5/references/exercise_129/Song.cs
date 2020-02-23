namespace exercise_129
{

  public class Song
  {

    private string artist;
    private string name;
    private int durationInSeconds;

    public Song(string artist, string name, int durationInSeconds)
    {
      this.artist = artist;
      this.name = name;
      this.durationInSeconds = durationInSeconds;
    }

    public override string ToString()
    {
      return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
    }

    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
      if( this.GetType().Equals(compared.GetType()) )
      {      
        Song cc = (Song)compared;
        if( (this.name == cc.name) && (this.artist == cc.artist) && (this.durationInSeconds == cc.durationInSeconds) ) return true;
        else return false;
      }
      else return false;
    }

    public override int GetHashCode()
    {
      return this.GetHashCode();
    }
    // END SOLUTION

  }

}