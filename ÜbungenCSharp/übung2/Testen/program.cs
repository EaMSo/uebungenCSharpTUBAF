using System;
namespace Hauptprogramm
{
    public class Einkaufen
    {
        static void Main()
        {
            Customer Max = new Customer(100, "Max Mustermann", "1618p");
            Customer Anna = new Customer(100, "Anna", "12314");
            Max.bezahlen(64324.12);
            Max.kontostand();
        }
    }
}