﻿using System;
using System.Collections.Generic;


///<summary>Public Class Obj</summary>
class Obj 
{
    ///<summary>IsOfTypeInt returns true or false based on matching types</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}

