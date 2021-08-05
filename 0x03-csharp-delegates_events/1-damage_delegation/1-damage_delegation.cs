using System;

//defining custome Delegate "CalculateHealth"
delegate float CalculateHealth(float x);
///<summary>Player class defines behavior for ojbects that inherit from Player</summary>
public class Player
{
    string name { get; set; }
    float maxHp { get; set; }
    float hp { get; set; }


    ///<summary>Player constructor</summary>
    ///<param name="name">String name passed in, default "Player"</param>
    ///<param name="maxHp">Float maxHp pass in, default 100f</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
          if (maxHp <= 0)
          {
              Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
              maxHp = 100f;
          }
            this.name = name;
            this.maxHp = maxHp;
            this.hp = maxHp;
    }

    ///<summary>Printhealth displays the player and stats about their health</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
    
    ///<summary>TakeDamage subtracts from the players hp.</summary>
    ///<param name="damage">Float passed to TakeDamage to be subracted from players hp.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }

    }
    
    ///<summary>HealDamage adds to the players hp.</summary>
    ///<param name="heal">Float passed to HealDamage to be added to players hp.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }

}