using Zoo.Interface;

namespace Zoo.Classes
{
    public abstract class Herbivores : Zoo, IAnimals
    {
        public virtual bool lovesPlants { get; set; } = false;

        public void IsBeautiful()
        {
            PrintColorMessage(ConsoleColor.Yellow, "A very beautiful creature");
        }
        public void AnimalType()
        {
            PrintColorMessage(ConsoleColor.Green, "My Animal Type: Mammal");
        }
        public void IsFriendly()
        {
            PrintColorMessage(ConsoleColor.Blue, "This animal is Friend. Pet it!!");
        }
        public void Speed()
        {
            PrintColorMessage(ConsoleColor.Red, "Very, Very Fast");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
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