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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

     ///<summary>Collect method</summary>
    public void Collect()
    {

    }

    ///<summary>Break method</summary>
    public void Break()
    {

    }

    ///<summary>Interact method</summary>
    public void Interact()
    {

    }
}



