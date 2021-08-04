using System;

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
