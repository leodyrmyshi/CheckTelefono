using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] vettore)
    {
        foreach (var num in vettore)
        {
            if (IsnumeroTelefonoItaliano(num))
            {
                return num;
            }
        }
        return "";
    }

    private static bool IsnumeroTelefonoItaliano(string num)
    {
        
        if(num.Length == 13 && (num.StartsWith("+39")))
        {
            return true;
        }
        if(num.Length == 14 && num.StartsWith("0039"))
        {
            return true;
        }
        if(num.Length == 10 && num.StartsWith("3"))
        {
            return true;
        }
        
        return false;
    }
}