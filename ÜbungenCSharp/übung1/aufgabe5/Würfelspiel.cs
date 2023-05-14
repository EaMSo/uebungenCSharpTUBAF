using System;
static class Program
{
    static void Main()
    {
        int GeldSpieler = 0;
        int zähler0 = 0;
        int zähler16 = 0;
        int zähler17 = 0;
        int zähler18 = 0;
        int wurfanzahl = 1000;
        Random randomizer = new Random();
        for(int i=0; i < wurfanzahl; i++)
        {
        int wurf = randomizer.Next(0,6)+1 + randomizer.Next(0,6)+1 + randomizer.Next(0,6)+1;
        if(wurf == 15)
        {
        GeldSpieler += 5;
        zähler16++;
        }
        else if(wurf == 16)
        {
        GeldSpieler += 10;
        zähler17++;
        }
        else if(wurf == 18)
        {
        GeldSpieler += 100;
        zähler18++;
        }
        else
        zähler0++;        
        }
        Console.WriteLine($"Der Spieler hat {wurfanzahl} mal gewürfelt und dabei die 16 {zähler16}mal gewürfelt!");
        Console.WriteLine($"                                ...und dabei die 17 {zähler17}mal gewürfelt!");
        Console.WriteLine($"                                ...und dabei die 18 {zähler18}mal gewürfelt!");
        Console.WriteLine();
        Console.WriteLine($"Der reine Gewinn ist somit {GeldSpieler}€!");
        Console.WriteLine($"Der Verlust ist somit {wurfanzahl}€!");
        Console.WriteLine($"Die Bilanz beträgt somit {GeldSpieler-wurfanzahl}€!");

    }





}