using System;
using Zoo.Classes;
using Zoo.Interface;

namespace Zoo
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.DarkYellow, "Welcome My Lovely Guest, I Hope your having a great day today!!!!");
            PrintColorMessage(ConsoleColor.Yellow, "Welcome to the best zoo around!!! Welcome to Zootopia!!!!");

            Console.WriteLine($"\n");

            // Creating a new instance of an animal
            Cow animal = new Cow("Cow", "Grass", "8pm-5am", "MOO!!!", "isAnAniaml");
            animal.AnimalSound();
            animal.RestTime();
            animal.FavoriteFood();
            animal.Type(animal);

            Console.WriteLine("\n");

            Lion animal2 = new Lion("Lion", "Meat", "7pm-5am", "ROAR!!!", "isAnAniaml");
            animal2.AnimalSound();
            animal2.RestTime();
            animal2.FavoriteFood();
            animal2.Type(animal2);

            Console.WriteLine("\n");

            Sheep animal3 = new Sheep("Sheep", "Hay", "5pm-12am", "BAA!!!", "isAnAniaml");
            animal3.AnimalSound();
            animal3.RestTime();
            animal3.FavoriteFood();
            animal3.Type(animal3);

            Console.WriteLine("\n");

            Horse animal4 = new Horse("Horse", "Hay", "4pm-9am", "NEIGH!!!", "isAnAniaml");
            animal4.AnimalSound();
            animal4.RestTime();
            animal4.FavoriteFood();
            animal4.Type(animal4);

            Console.WriteLine("\n");

            KillerWhale animal5 = new KillerWhale("KillerWhale", "Fish", "4pm", "SQUAWKS!!!", "isAnAniaml");
            animal5.AnimalSound();
            animal5.RestTime();
            animal5.FavoriteFood();
            animal5.Type(animal5);

            // just passing information down
            // string lion = "Lion goes: ROAR!!!";
            // string lionRest = "7pm-5am";
            // string lionFood = "Meat";

            // string horse = "Horse goes: NEIGH!!!";
            // string horseRest = "4pm-9am";
            // string horseFood = "Hay";

            // string sheep = "Sheep goes: BAA!!!";
            // string sheepRest = "5pm-12am";

            // string cow = "Cow goes: MOO!!!";
            // string cowRest = "8pm-5am";
            // string cowFood = "Grass";

            // string dolphin = "Dolphin goes: SQUAWKS!!!";
            // string dolphinRest = "4pm";
            // string dolphinFood = "Fish";

        }
        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            //  just for fun change the console color of the text
            Console.ForegroundColor = color;

            //  write the message passed to it to the console
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}