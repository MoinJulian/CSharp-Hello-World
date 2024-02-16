using System;

namespace HelloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Herr Meier";
            string date = "16/02/2024";

            int amount = 3;
            double price = 7.95;
            double total = amount * price;

            Console.WriteLine("Hallo "+ name + @",
Hiermit übersende ich Ihnen die Rechnung für meine Leistung am " + date + @" Vielen Dank, dass Sie unsere Diesnste genutzt haben.

Mit freundlichen Grüßen,
Julian Hammer

Menge: " + amount + @"
Preis: " + price + @"
Gesamt: " + total+ @"
 ");

        }
    }
}