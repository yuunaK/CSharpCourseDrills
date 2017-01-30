using System;

public abstract class Flower
{
    public abstract void Garland(string flower1, string flower2, string flower3);
    public abstract void Wreath(string flower1, string flower2, string flower3);
}

public class Flower2 : Flower
{
    public override string Garland(string flower1, string flower2, string flower3)
    {
        string flowerGarland = flower1 + flower2 + flower3;
        return flowerGarland;
    }
}

public class Flower3 : Flower
{
    public override string Wreath(string flower1, string flower2, string flower3)
    {
        string[] flowerArray = { flower1, flower2, flower3 };
        foreach (string i in flowerArray)
        {
            System.Console.WriteLine("{0}", i);

        }
    }
}

public class OverloadingExample
{
    void G();
    void G(int y);
    string G(string text1);
    int G(int x, int z);
    void G(ref int r);



}
