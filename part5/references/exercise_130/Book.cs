namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
      if( this.GetType().Equals(compared.GetType()) )
      {      
        Book cc = (Book)compared;
        if( (this.name == cc.name) && (this.publicationYear == cc.publicationYear) ) return true;
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