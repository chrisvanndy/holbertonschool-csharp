using System;

///<summary>Base, an abstract class, defines properties and methods for Base class</summary>
abstract class Base
{
    public string name = "";

    ///<summary>ToString (overridden) returns informations about the object instance being operated on.</summary>
    public override string ToString()
    {
        return (this.name + " is a " + this.GetType().ToString());
    }
}

