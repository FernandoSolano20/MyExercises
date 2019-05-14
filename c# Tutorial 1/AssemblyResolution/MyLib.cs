using System;

public static class Foo
{
    public static void PrintLocation()
    {
        Console.WriteLine(typeof(Foo).Assembly.Location);
    }
}