using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Repro");
        var inflater = new Inflater(true);
    }
}
