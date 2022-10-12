namespace Zoo.Classes
{
    class Horse : Herbivores
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public override string Sleep { get; set; }
        public override string Sound { get; set; }
        public override bool lovesPlants { get; set; } = true;
        public Horse(string name, string food, string sleep, string sound)
        {
            Name = name;
            Food = food;
            Sleep = sleep;
            Sound = sound;
        }
        public override void AnimalSound()
        {
            PrintColorMessage(ConsoleColor.DarkMagenta, $"The {Name} goes {Sound} ");
        }
        public override void RestTime()
        {
            PrintColorMessage(ConsoleColor.Green, $"This animal is sleep around: {Sleep} ");
        }
        public override void FavoriteFood()
        {
            PrintColorMessage(ConsoleColor.Cyan, $"This animal's favorite food is: {Food}");
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
    class Sheep : Herbivores
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public override string Sleep { get; set; }
        public override string Sound { get; set; }
        public override bool lovesPlants { get; set; } = true;
        public Sheep(string name, string food, string sleep, string sound)
        {
            Name = name;
            Food = food;
            Sleep = sleep;
            Sound = sound;
        }
        public override void AnimalSound()
        {
            PrintColorMessage(ConsoleColor.DarkMagenta, $"The {Name} goes {Sound} ");
        }
        public override void RestTime()
        {
            PrintColorMessage(ConsoleColor.Green, $"This animal is sleep around: {Sleep} ");
        }
        public override void FavoriteFood()
        {
            PrintColorMessage(ConsoleColor.Cyan, $"This animal's favorite food is: {Food}");
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
    class Cow : Herbivores
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public override string Sleep { get; set; }
        public override string Sound { get; set; }
        public override bool lovesPlants { get; set; } = true;
        public Cow(string name, string food, string sleep, string sound)
        {
            Name = name;
            Food = food;
            Sleep = sleep;
            Sound = sound;
        }
        public override void AnimalSound()
        {
            PrintColorMessage(ConsoleColor.DarkMagenta, $"The {Name} goes {Sound} ");
        }
        public override void RestTime()
        {
            PrintColorMessage(ConsoleColor.Green, $"This animal is sleep around: {Sleep} ");
        }
        public override void FavoriteFood()
        {
            PrintColorMessage(ConsoleColor.Cyan, $"This animal's favorite food is: {Food}");
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