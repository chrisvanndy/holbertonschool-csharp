using System;


class Except
{
    public static void ThrowMsg(string msg)
    {
        string myStr = msg;
        Exception newExcept = new Exception(msg);
        throw newExcept;
    }
}

