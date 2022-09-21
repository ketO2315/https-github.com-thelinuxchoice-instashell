using System;

namespace Lqtno_Obleklo
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradusi = double.Parse(Console.ReadLine());
            string vremeNaDenq = Console.ReadLine();
            string outfit = "";
            string obuvki = "";

            if (gradusi >=10 && gradusi <=18)
            {
                if (vremeNaDenq == "Morning")
                {
                    outfit = "Sweatshirt";
                    obuvki = "Sneakers";
                }
                else if (vremeNaDenq == "Afternoon")
                {
                    outfit = "Shirt";
                    obuvki = "Moccasins";
                }
                else
                {
                    outfit = "Shirt";
                    obuvki = "Moccasins";
                }
               
            }
            else if (gradusi >18 && gradusi <=24)
            {
                if (vremeNaDenq == "Morning")
                {
                    outfit = "Shirt";
                    obuvki = "Moccasins";
                }
                else if (vremeNaDenq == "Afternoon")
                {
                    outfit = "T-Shirt";
                    obuvki = "Sandals";
                }
                else 
                {
                    outfit = "Shirt";
                    obuvki = "Moccasins";

                }
            }
            else if (gradusi >=25)
            {
                if (vremeNaDenq == "Morning")
                {
                    outfit = "T-Shirt";
                    obuvki = "Sandals";
                }
                else if (vremeNaDenq == "Afternoon")
                {
                    outfit = "Swim Suit";
                    obuvki = "Barefoot";
                }
                else
                {
                    outfit = "Shirt";
                    obuvki = "Moccasins";
                }

               

            }
            Console.WriteLine($"It's {gradusi} degrees, get your {outfit} and {obuvki}.");
        }
    }
}
