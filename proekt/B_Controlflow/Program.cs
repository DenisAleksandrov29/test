using System;

namespace B_Controlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassindex = weight / (height * height);

            bool isTooLow = bodyMassindex <= 18.5;
            bool isNormal = bodyMassindex > 18.5 && bodyMassindex < 25;
            bool isAboveNormal = bodyMassindex >= 25 && bodyMassindex <= 30;
            bool isTooFat = bodyMassindex > 30;

            bool isfat = isAboveNormal || isTooFat;


            if (isfat)
            {
                Console.WriteLine("You'd better lose some weight");

            }
            else
            {
                Console.WriteLine("oh, you're in a good shape.");
            }

            if (!isfat)
            {
                Console.WriteLine("You're definitely not fat!");
            }
            if(isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if(isNormal)
            {
                Console.WriteLine("You're ok");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }
            if(isfat || isfat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }

            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
            Console.WriteLine(description);
        }
    }
}
