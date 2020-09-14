using System;

namespace TextAdventure
{
    class Game
    {
        static string PersonName = "John Doe";
        static string BirthMonth = "January";
        static string BirthDay = "1st";
        static string FavoriteColor = "blue";
        static string EndStatement = "()";

        static void StartGame()
        {
            Console.WriteLine("Welcome to my Text Adventure!");
        }

        static void NameOfPerson()
        {
            Console.WriteLine("What is your name?");
            PersonName = Console.ReadLine();
            Console.WriteLine($"Great, thank you for playing {PersonName}!");
        }

        static void MonthOfBirth()
        {
            Console.WriteLine($"What month were you born in, {PersonName}?");
            BirthMonth = Console.ReadLine();
            Console.WriteLine($"Thanks for sharing your birth month, {PersonName}!");
        }

        static void DayOfBirth()
        {
            Console.WriteLine($"What day were you born on in {BirthMonth}, {PersonName}?");
            BirthDay = Console.ReadLine();
            Console.WriteLine($"Thank you for sharing your birthday, {PersonName}!");
        }

        static void FavColor()
        {
            Console.WriteLine($"{PersonName}, what is your favorite color?");
            FavoriteColor = Console.ReadLine();
            Console.WriteLine($"Thank you {PersonName}, I like {FavoriteColor} too!");
        }

        static void EndingStatement()
        {
            Console.WriteLine($"Based on your feedback {PersonName}, I know that you were born on {BirthMonth} {BirthDay}, and your favorite color is {FavoriteColor}. Thank you for playing along on my Text Adventure!");
        }

        class Program
        {
            static void Main()
            {
                Game.StartGame();               
                Game.NameOfPerson();
                Game.MonthOfBirth();
                Game.DayOfBirth();
                Game.FavColor();
                Game.EndingStatement();
                Console.ReadKey();
            }
        }
    }
}
