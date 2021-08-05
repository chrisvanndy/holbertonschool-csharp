using System;

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
}