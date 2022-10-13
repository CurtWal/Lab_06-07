using Zoo.Interface;

namespace Zoo.Classes
{
    public abstract class Predators : Zoo, IAnimals
    {
        public virtual bool lovesMeat { get; set; } = false;
        public void IsBeautiful()
        {
            PrintColorMessage(ConsoleColor.Red, "A very beautiful creature");
        }
        public void AnimalType()
        {
            PrintColorMessage(ConsoleColor.Cyan, "My Animal Type: Mammal");
        }
        public void IsFriendly()
        {
            PrintColorMessage(ConsoleColor.Green, "This animal is not FRIENDLY. STAY AWAY!!!");
        }
        public void Speed()
        {
            PrintColorMessage(ConsoleColor.Yellow, "Very, Very Fast");
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