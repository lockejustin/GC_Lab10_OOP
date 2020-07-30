using System;
using System.Collections.Generic;
using System.Linq;

namespace GC_Lab10_MovieList_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>() { };
            string[] categories = { "scifi", "animated", "horror", "drama" };
            movieList = CreateList();  //calls method to create the list of movies
            bool continueProgram = true;


            while (continueProgram)  //continues the program as long as the user selects yes
            {
                Console.WriteLine("Welcome to the Movie List App!");
                PromptUser(movieList, categories);
                continueProgram = ContinueProgramYesNoPrompt("Would you like to choose a new category?");
            }
        }
        public static List<Movie> CreateList()  //creates a list with all of the movie objects
        {
            List<Movie> movieList = new List<Movie>() { };

            movieList.Add(new Movie("Avengers: Endgame", "scifi", 94, false));
            movieList.Add(new Movie("Avengers: Infinity War", "scifi", 85, false));
            movieList.Add(new Movie("Star Wars: The Empire Strikes Back", "scifi", 94, false));
            movieList.Add(new Movie("Back to the Future", "scifi", 96, false));
            movieList.Add(new Movie("Up", "animated", 98, false));
            movieList.Add(new Movie("Spider-Man: Into the Spider-Verse", "animated", 97, true));
            movieList.Add(new Movie("The Lion King", "animated", 93, false));
            movieList.Add(new Movie("Us", "horror", 93, false));
            movieList.Add(new Movie("Get Out", "horror", 98, false));
            movieList.Add(new Movie("Young Frankenstein", "horror", 94, false));
            movieList.Add(new Movie("The Godfather", "drama", 98, false));
            movieList.Add(new Movie("Jaws", "drama", 98, false));
            movieList.Add(new Movie("A Quiet Place", "drama", 96, false));
            movieList.Add(new Movie("Face/Off", "drama", 92, true));
            movieList.Add(new Movie("Con Air", "drama", 55, true));
            movieList.Add(new Movie("National Treasure", "drama", 46, true));
            movieList.Add(new Movie("Ghost Rider", "scifi", 26, true));
            movieList.Add(new Movie("Bangkok Dangerous", "drama", 8, true));
            movieList.Add(new Movie("The Rock", "drama", 66, true));
            movieList.Add(new Movie("Gone in 60 Seconds", "drama", 25, true));


            return movieList;
        }

        public static void PromptUser(List<Movie> movies, string[] categories)
        {
            
            bool validEntry = false;
            string userEntry = "";
            int menuSelection = 0;

            while (!validEntry)  //loops through contained code until a valid entry is received
            {
                Console.WriteLine($"There are {movies.Count} movies in this list.");
                Console.WriteLine("What category are you interested in?  Please choose from the following categories.");

            for (int i = 0; i < categories.Length; i++)  //displays a list of categories to choose from
            {
                Console.WriteLine($"{i+1}. {categories[i]}");
            }

            userEntry = Console.ReadLine();  //receives input from the user
            
                if (int.TryParse(userEntry, out int n))  //tests to see if input is an int and within range
                {
                    if (n >=1 && n <= categories.Length)
                    {
                        validEntry = true;
                        menuSelection = n;
                    }
                    else
                    {
                        Console.WriteLine("Your entry was invalid.  Please try again.");
                        validEntry = false;
                    }
                }
                else  //triggers if alpha characters are entered
                {
                    Console.WriteLine("Your entry was invalid.  Please try again.");
                    validEntry = false;
                }
            }

            int index = menuSelection-1;

            movies = movies.OrderBy(x => x.Title).ToList();  //sorts movie list alphabetically by title

            for (int i = 0; i < movies.Count; i++)  //iterates through the movies list and prints the movie if the category matches the choice of the user
            {
                if (movies[i].Category == categories[index])
                {    
                    if (movies[i].NicCage == true)
                    {
                        Console.WriteLine($"{ movies[i].Title} has a Rotten Tomatoes of {movies[i].RTScore} and features the actor Nicolas Cage!");
                    }
                    else
                    {
                        Console.WriteLine($"{ movies[i].Title} has a Rotten Tomatoes of {movies[i].RTScore} and sadly does not feature the actor Nicolas Cage.");
                    }
                }
            }
        }

        public static bool ContinueProgramYesNoPrompt(string message)  //prompts user if they'd like to continue and verifies proper entry
        {
            Console.Write($"{message} (y/n) ");
            string response = Console.ReadLine().ToLower();

            while (response != "y" && response != "n")  //checks to make sure the user enters either y or n
            {
                Console.Write("Your entry was invalid.  Please respond (y/n) ");
                response = Console.ReadLine().ToLower();
            }

            if (response == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Thanks for using this program.  Goodbye!");
                return false;
            }
        }
    }


}
