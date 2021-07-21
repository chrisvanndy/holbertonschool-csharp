using System;

namespace Enemies
{
    ///<summary>Represents the Zombie class</summary>
    public class Zombie
    {
        /// <summary>Sets the value for health.</summary>
        public int health;

       /// <summary>Initializes a new instance of Zombie class.</summary>
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
        
          /// <summary>Returns value of health of Zombie object.</summary>
          public int GetHealth()
          {
              return this.health;
          }

     }
}
