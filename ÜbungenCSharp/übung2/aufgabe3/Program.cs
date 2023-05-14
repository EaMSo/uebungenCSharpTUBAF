using System;
using System.Collections;
using System.Collections.Generic;

public struct Size
{
    public Size(double width, double height)
    {
        if(width < 0 || height < 0)
        {
            throw new System.ArgumentException(); //??????
        }
        else
        {
            this.Width = width;
            this.Height = height;
        }
    }

    public double Width;
    public double Height;
}
public class Programm
{
    static void Main()
    {
        Size rechteck = new Size(-10.2, 32.13);
        System.Console.WriteLine(rechteck.Width);
    }
}