using System;
using System.Collections.Generic;

namespace extra_18
{
   public class BirdDatabase
    {
        List<Bird> birds;

        public BirdDatabase()
        {
            birds = new List<Bird>();
            this.birds = new List<Bird>();          
        }       

        public void Add(Bird bird)
        {            
            bool exists = false;
           
            foreach(Bird b in this.birds)
            {
                if(b.ToString() == bird.ToString() )
                {
                    exists = true;
                    break;
                } 
            }
            if(!exists)
            {
                birds.Add(bird);
                exists = false;
            }
        }

        public void All()
        {
            foreach (Bird b in this.birds)
            {
              System.Console.WriteLine(b.ToString());
            }
        }

/*        public string One(string name)
        {
            foreach (Bird b in this.birds)
            {
                if(b.GetName() == name)
                {
                    return b.ToString();                    
                }                  
            }
            return "Not a bird!"; 
        }*/

        public Bird One(string name)
        {
            foreach (Bird b in this.birds)
            {
                if(b.GetName() == name)
                {
                    return b;                    
                }                  
            }
            return null; 
        }
    }
}