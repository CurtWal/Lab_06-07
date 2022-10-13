using Zoo.Interface;

namespace Zoo.Classes
{
    class KillerWhale : Predators, IisAnimal
    {
        public string isAnAnimal { get; set; }
        public override string Name { get; set; }
        public override bool lovesMeat { get; set; } = true;
        public override string Food { get; set; }
        public override string Sleep { get; set; }
        public override string Sound { get; set; }
        public KillerWhale(string name, string food, string sleep, string sound, string animal)
        {
            Name = name;
            Food = food;
            Sleep = sleep;
            Sound = sound;
            isAnAnimal = animal;
        }
        public string Type(IAnimals animal)
        {
            animal.IsBeautiful();
            animal.Speed();
            animal.AnimalType();
            animal.IsFriendly();
            return "I am an animal";
        }

        public string AdjustSettings()
        {
            return "All my settings are adjusted";
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
    class Lion : Predators, IisAnimal
    {
        public string isAnAnimal { get; set; }
        public override string Name { get; set; }
        public override bool lovesMeat { get; set; } = true;
        public override string Food { get; set; }
        public override string Sleep { get; set; }
        public override string Sound { get; set; }
        public Lion(string name, string food, string sleep, string sound, string animal)
        {
            Name = name;
            Food = food;
            Sleep = sleep;
            Sound = sound;
            isAnAnimal = animal;
        }
        public override void AnimalSound()
        {
            PrintColorMessage(ConsoleColor.Cyan, $"The {Name} goes {Sound} ");
        }
        public override void RestTime()
        {
            PrintColorMessage(ConsoleColor.DarkMagenta, $"This animal is sleep around: {Sleep} ");
        }
        public override void FavoriteFood()
        {
            PrintColorMessage(ConsoleColor.Green, $"This animal's favorite food is: {Food}");
        }
        public string Type(IAnimals animal)
        {
            animal.IsBeautiful();
            animal.Speed();
            animal.AnimalType();
            animal.IsFriendly();
            return "I am an animal";
        }
        public string AdjustSettings()
        {
            return "All my settings are adjusted";
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