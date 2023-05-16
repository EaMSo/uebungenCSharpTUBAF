using System;
public struct Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        if(width < 0 || height < 0)
        {
            throw new System.ArgumentException();
        }
        else
        {
            this.width = width;
            this.height = height;
        }
    }

    public double Width
    {
        get { return width; }
         set
        {
            if (value > 0)
            {
                width = value;
            }
            else throw new System.ArgumentException();
        }
    }
    public double Height
    {
        get { return height; }
         set
        {
            if (value > 0)
            {
                height = value;
            }
            else throw new System.ArgumentException(); 
        }
    }
}

public class Programm
{
    static void Main()
    {
        Size rechteck = new Size(10.2, 32.13);
        System.Console.WriteLine(rechteck.Width);
        rechteck.Width = 12;
        System.Console.WriteLine(rechteck.Width);
    }
}