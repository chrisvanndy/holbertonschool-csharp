using System;

///<summary>CaclulateHealth definines custome Delegate "CalculateHealth"</summary>
public delegate void CalculateHealth(float x);
///<summary>CalculateModifier defines custom Delegate "CalculateModifier"</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
///<summary>Modifier is an enum that sets constants related to player hp</summary>
public enum Modifier
{
    ///<summary>Weak decreases hp by .5</summary>
    Weak,
    ///<summary>Base acts as player hp</summary>
    Base,
    ///<summary>Srong increases player hp by 1.5</summary>
    Strong

}

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
              throw new Exception("maxHp must be greater than 0. maxHp set to 100f by default.");
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

        this.hp = this.hp - damage;
        CalculateHealth subHP = ValidateHP;
        subHP(this.hp);

    }
    
    ///<summary>HealDamage adds to the players hp.</summary>
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

        this.hp = this.hp + heal;
        CalculateHealth addHP = ValidateHP;
        addHP(this.hp);

    }

    ///<summary>ValidateHP handles +/- of hp via calls to HealDamage/TakeDamage methods and sets the new value of player hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }

    }

    ///<summary>ApplyModifier determines modifiers to damage or heal on players hp.</summary>
    ///<param name="baseValue">baseValue is a neutral value, no damage or heal.</param>
    ///<param name="modifier">modifier increases or decreases health based on Modifier enum.</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue * 0.5f);
        }
        else if (modifier == Modifier.Strong)
        {
            return (baseValue * 1.5f);
        }
        else 
        {
            return baseValue;
        }
    }

}

