using System;

namespace c2_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Hero1 info
            string characterName = "Aether";
            string superPower1 = "FireBalls";
            string superPower2 = "Armor";
            int characterage = 17;
            //int height = 173;
            int characterPower = 205;
            double characterSpeed = 1.5;

            //Hero2 info
            string heroName = "Venti";
            int heroAge = 25;
            //int heroHeight = 156;
            string heroSuperPower1 = "superSpeed";
            string heroSuperPower2 = "windPower";
            int heroPower = 190;
            int heroSpeed = 2;

            int ageDifference = 25 - 17;
            int heightCheck = 173 - 156;

            Console.WriteLine("My name is " + characterName + " and my super powers are " + superPower1 + " and " + superPower2 + ". My age is " + characterage + " and my speed is " + characterSpeed);
            Console.WriteLine("My name is " + heroName + " and my super powers are " + heroSuperPower1 + " and " + heroSuperPower2 + ". My age is " + heroAge + " and my speed is " + heroSpeed);

            Console.WriteLine("The age difference between the two heros is " + ageDifference + " years.");
            Console.WriteLine("Aether is taller by " + heightCheck + " cm.");

            if (characterPower > heroPower)
            {
                Console.WriteLine("Aether is more powerful.");
            }
            else if (heroPower > characterPower)
            {
                Console.WriteLine("Venti is more powerful.");
            }
            else
            {
                Console.WriteLine("Neither is more powerful.");
            }
        }
    }
}
