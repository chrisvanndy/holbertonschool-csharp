using System;


class Except
{
    public static void Throw()
    {
        Exception newException = new Exception("Defined new exception for task 3");
        throw newException;
    }
}

// "throw new Exception; also works and is less code
