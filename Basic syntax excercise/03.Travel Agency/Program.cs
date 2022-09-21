using System;

namespace _03.Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string packetType= Console.ReadLine();
            string VIP= Console.ReadLine();
            int daysSpend = int.Parse(Console.ReadLine());
            int days = 0;
            double priceForDay = 0;

            if (daysSpend <1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (daysSpend >7)
            {
                days--;
            }

            switch (cityName)
            {
                case "Bansko":
                case "Borovets":

                    if (packetType == "noEquipment")
                    {
                        priceForDay = daysSpend * 80;
                    }
                    if (VIP == "yes")
                    {
                        priceForDay -= priceForDay * 0.05;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                    if (packetType == "withEquipment")
                    {
                        priceForDay = daysSpend * 100;
                    }
                    if (VIP == "yes")
                    {
                        priceForDay -= priceForDay * 0.10;
                    }
                    break;

                case "Varna":
                case "Burgas":

                    if (packetType == "noBreakfast")
                    {
                        priceForDay = daysSpend * 100;

                    }
                    if (VIP == "yes")
                    {
                        priceForDay -= priceForDay * 0.07;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                    if (packetType == "withBreakfast")
                    {
                        priceForDay = daysSpend * 130;
                    }
                    if (VIP == "yes")
                    {
                        priceForDay -= priceForDay * 12;
                    }

                    break;
     
            }
            Console.WriteLine($"The price is {priceForDay:F2}lv! Have a nice time!");
        }
    }
}
