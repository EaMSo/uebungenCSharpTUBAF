using System;
class Program
{
    static double[] GetRandomArray(int längearray, double minNumber, double maxNumber)
    {
    Random randomizer = new Random();
    double[]doubArray = new double[längearray];
    for (int i = 0; i < längearray; i++)
    {
        doubArray[i] = Math.Round(randomizer.NextDouble()* (maxNumber - minNumber) + minNumber, 2);
    }

    return doubArray;
    }
    static void Main()
    {
        double GesamtCo2kittsundnevis = 0;
        double GesamtCo2niue = 0;
        for(int i=0; i<5; i++)
        {
        double [] co2kittsundnevis = GetRandomArray(365,0.054,0.21);
        double [] co2niue = GetRandomArray(365,0.054,0.21);
        double GesamtJahrnevis = 0; 
        double GesamtJahrniue = 0;
            for(int n=0; n<365; n++)
            {
                GesamtCo2kittsundnevis += co2kittsundnevis[n];
                GesamtCo2niue += co2niue[n];
                GesamtJahrniue += co2niue[n];
                GesamtJahrnevis += co2kittsundnevis[n];
            }
        if(GesamtJahrniue<GesamtJahrnevis)
        Console.WriteLine($"Jahr {i+1}: St. Kitts und Nevis hatte einen größeren CO2 Ausstoß mit {GesamtJahrnevis:F2} Millionen Tonnen als Niue mit {GesamtJahrniue:F2} Millionen Tonnen!");
        else if(GesamtJahrniue>GesamtJahrnevis)
        Console.WriteLine($"Jahr {i+1}: Niue hatte einen größeren Ausstoß CO2 mit {GesamtJahrniue:F2} Millionen Tonnen als St. Kitts und Nevis mit {GesamtJahrnevis:F2} Millionen Tonnen!");
        else
        Console.WriteLine($"Jahr {i+1}: Niue und St. Kitts haben den gleichen CO2 Ausstoß!");
        }
        Console.WriteLine(); //?
        Console.WriteLine($"Gesamtausstoß CO2 St. Kitts und Nevis:  {GesamtCo2kittsundnevis:F2} Millionen Tonnen!");
        Console.WriteLine($"Gesamtausstoß CO2 Niue:                 {GesamtCo2niue:F2} Millionen Tonnen!");

    }



}