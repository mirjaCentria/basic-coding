using System;

namespace extra_18
{
    public class UserInterface
    {
        public BirdDatabase db;
        public UserInterface(BirdDatabase db)
        {
            this.db = db;
        }  

        public void Start()
        {
            string action = "";

            System.Console.WriteLine("Starting BirdDatabase!");
            System.Console.WriteLine("Write Add, Observation, All, One or End");

            while(true)
            {
                action = System.Console.ReadLine();
                if(action == "Add") this.Add();
                else if(action == "Observation") this.Observation();
                else if(action == "All") this.All();
                else if(action == "One") this.One();
                else if(action == "End") break;
                else System.Console.WriteLine("Say what?");
            }

        }

        public bool Check(string name)
        {
            if(this.db.One(name) == null) return false;
            else return true;
        }
        public void Add()
        {            
            System.Console.WriteLine("Name:");
            string name  = System.Console.ReadLine();
   
            if(this.Check(name)) System.Console.WriteLine("Bird already exists in db");
            else
            {
                System.Console.WriteLine("Latin name:");
                string latinName  = System.Console.ReadLine();
                db.Add(new Bird(name, latinName));
              //  System.Console.WriteLine(name + " added");
            }
        }

        
        public void Observation()
        {
            System.Console.WriteLine("Bird?");
            string name = System.Console.ReadLine();
            if(!this.Check(name)) System.Console.WriteLine("Not a bird");
            else 
            {
                Bird b = this.db.One(name);
                b.AddObservation();
               // System.Console.WriteLine(name + " observation added");
            }
        }

        
        public void All()
        {
           /// System.Console.WriteLine("All birds:");
            this.db.All();            
        }

        
        public void One()
        {
            System.Console.WriteLine("Bird?");
            string name = System.Console.ReadLine();

            if(this.db.One(name) != null)
                System.Console.WriteLine(this.db.One(name).ToString());  
            else System.Console.WriteLine("Not a bird!");
        }
    }


}