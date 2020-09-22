using System;

namespace TextAdventure
{
    class Game
    {
        static string PersonName = "John Doe";
        static string BirthMonth = "January";
        static string BirthDay = "1st";
        static string FavoriteColor = "blue";
        static string FilmsAthletics = "football";
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
            Console.WriteLine($"Thank you {PersonName}, {FavoriteColor} is a great color!");
        }

        static void MoviesAndSports()
        {
            var ent1 = ("movies");
            var ent2 = ("sports");
            Console.WriteLine($"Do you prefer to watch either movies or sports for entertainment, {PersonName}?");
            FilmsAthletics = Console.ReadLine();

            if (FilmsAthletics == null || FilmsAthletics.Length == 0)
            {
                Console.WriteLine($"I am sorry to hear that you don't like either one, {PersonName}");
            }
            else if (FilmsAthletics == ent1)
            {
                Console.WriteLine($"{PersonName}, I also really enjoy watching movies!");
            }
            else if (FilmsAthletics == ent2)
            {
                Console.WriteLine($"{PersonName}, I also love watching sports!");
            }
        }
             

            static void EndingStatement()
            {
                Console.WriteLine($"Based on your feedback {PersonName}, I know that you were born on {BirthMonth} {BirthDay}, your favorite color is {FavoriteColor}, and you enjoy watching {FilmsAthletics} for entertainment. Thank you for playing along on my Text Adventure!");
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
                Game.MoviesAndSports();
                Game.EndingStatement();
                Console.ReadKey();
            }
        }
    }
}
