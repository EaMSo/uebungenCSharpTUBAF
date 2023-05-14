using System; 
class Program
{
    static double[] GetRandomNutArray(int mindestlänge, int maximallänge, double minNumber, double maxNumber)
    {
    Random randomizer = new Random();
    int arraySize = randomizer.Next(mindestlänge, maximallänge);
    double[]doubArray = new double[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        doubArray[i] = Math.Round(randomizer.NextDouble()* (maxNumber - minNumber) + minNumber, 2);
    }

    return doubArray;
    }

    static double GetAverageNutVolume(List<double> liste)
    {
        double durchschnittsvolumen = 1;
        foreach (double element in liste)
        {
            durchschnittsvolumen += (1.0/6.0) * Math.PI * element * element * element;
        }
        return durchschnittsvolumen/liste.Count();
    }

    static void Main()
    {
        double [] arry= GetRandomNutArray(10000, 10000, 0.75, 4.0);
        var Haselnüsse = new List<double>();
        var Wallnüsse = new List<double>();

        foreach (double arrays in arry)
        {
            if(arrays<2) {Haselnüsse.Add(arrays);}
            else {Wallnüsse.Add(arrays);}
        }

        Console.Clear();
        Console.WriteLine("In dem Haufen sind {0} Haselnüsse mit einem durschnittlichen Volumen von {1:F2}cm^3",Haselnüsse.Count(), GetAverageNutVolume(Haselnüsse));  
        Console.WriteLine("In dem Haufen sind {0} Wallnüsse mit einem durschnittlichen Volumen von {1:F2}cm^3",Wallnüsse.Count(), GetAverageNutVolume(Wallnüsse));
    }
}