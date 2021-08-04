﻿using System;
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

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        //given list of type BASE
        foreach (Base item in roomObjects)
        {
            // iterate through the list, each item.
            // if item is compatible with IInteractive and type is the same type.
            if (item is IInteractive && type == typeof(IInteractive))
            {
                //to access appropriate method for roomObject typecast to correct interface
                ((IInteractive)item).Interact();
            }
            if (item is ICollectable && type == typeof(ICollectable))
            {
                ((ICollectable)item).Collect();
            }
            if (item is IBreakable && type == typeof(IBreakable))
            {
                ((IBreakable)item).Break();
            }
        }

      
    }
}
