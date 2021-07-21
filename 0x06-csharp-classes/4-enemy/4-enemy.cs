using System;

namespace Enemies
{
    ///<summary>Represents the Zombie class</summary>
    public class Zombie
    {
        /// <summary>Private class field Sets the value for health.</summary>
        private int health;
        /// <summary> Private class field sets the value of name. </summary>
        private String name = "(No name)";

       /// <summary>Constructor sets fields within Zombie class.</summary>
        public Zombie()
        {
        health = 0;
        }

        /// <summary>Initializes a new instance of Zombie class with passed int variable.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            
            health = value;
        }
        
        /// <summary>Returns value of health within Zombie object.</summary>
        public int GetHealth()
        {
            return this.health;
        }
         
         
         /// <summary>Gets and Sets the value of private field name of Zombie object.</summary>
         
         public string Name 
         { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
         }

     }
}

