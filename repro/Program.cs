using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Repro");
    }

    static Program()
    {
        byte[] codeLengths = new byte[288];
        codeLengths = new byte[32];
        int i = 0;
        while (i < 32)
        {
            codeLengths[i++] = 5;
        }

    }
}
