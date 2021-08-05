using System;
using System.Collections;
using System.Collections.Generic;

///<summary>Base, an abstract class, defines properties and methods for Base class</summary>
abstract class Base
{
    public string name { get; set; }

    ///<summary>ToString (overridden) returns informations about the object instance being operated on.</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

///<summary>IInteractive is a public interface</summary>
interface IInteractive
{
    void Interact();
}

///<summary>IBreakable is a public interface</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>ICollectable is a public interface</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary>TestObject inherits from Base, and all interfaces.</summary>

///<summary>Door class inherits from Base and IInteractive</summary>
class Door : Base, IInteractive
{
    //constructor provides a default vaule if one is not given
    public Door(string def = "Door")
    {
        name = def;
    }
    ///<summary>Interact prints a string that describes interaction with object</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        }
    }

    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        else if (durability < 0)
        {
            Console.WriteLine("The {0} is already broken.", name);
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else 
        {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
    }
}

///<summary> ObjsT can be anything it wants to be</summary>
class Objs<T> : IEnumerable<T>
{
    // declare list to assign an enumerator to.
    List<T> objects = new List<T>();

    ///<summary>define Add method's behavior for adding objects to a generic list</summary>
    public void Add(T item)
    {
        objects.Add(item);
    }

    // return IEnumerator object // "GetEnumerator()" points at collection
    IEnumerator IEnumerable.GetEnumerator()
    {
        return (GetEnumerator());
    }

    ///<summary>GetEnumerator returns IEnumerator ojbect with access to generic ojbects list.</summary>
    public IEnumerator<T> GetEnumerator()
    {
        return (objects.GetEnumerator());
    }

}
