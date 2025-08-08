//5. Create a CRUD based App for developing a Movie Database software where the user can add,
//remove and update movies of his Video library. It should be a menu driven program that has 4 use cases for
//add, removing, finding and updating movie info in the application.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment5
    {
        class Movie
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string Director { get; set; }
        }

        class Program
        {
            static List<Movie> movieList = new List<Movie>();
            static int nextId = 1;
            static void Main()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n--- Movie Database Menu ---");
                    Console.WriteLine("1. Add Movie");
                    Console.WriteLine("2. Find Movie");
                    Console.WriteLine("3. Update Movie");
                    Console.WriteLine("4. Remove Movie");
                    Console.WriteLine("5. Display All Movies");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            AddMovie();
                            break;
                        case 2:
                            FindMovie();
                            break;
                        case 3:
                            UpdateMovie();
                            break;
                        case 4:
                            RemoveMovie();
                            break;
                        case 5:
                            DisplayAllMovies();
                            break;
                        case 0:
                            Console.WriteLine("Exiting program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                } while (choice != 0);
            }

            static void AddMovie()
            {
                Console.Write("Enter movie title: ");
                string title = Console.ReadLine();
                Console.Write("Enter director name: ");
                string director = Console.ReadLine();
                Console.Write("Enter release year: ");
                int year = int.Parse(Console.ReadLine());
                Movie movie = new Movie
                {
                    Id = nextId++,
                    Title = title,
                    Director = director,
                    Year = year
                };
                movieList.Add(movie);
                Console.WriteLine("Movie added successfully!");
            }
            static void FindMovie()
            {
                Console.Write("Enter movie ID to find: ");
                int id = int.Parse(Console.ReadLine());
                Movie movie = movieList.Find(m => m.Id == id);
                if (movie != null)
                {
                    Console.WriteLine($"ID: {movie.Id}, Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }

            static void UpdateMovie()
            {
                Console.Write("Enter movie ID to update: ");
                int id = int.Parse(Console.ReadLine());
                Movie movie = movieList.Find(m => m.Id == id);
                if (movie != null)
                {
                    Console.Write("Enter new title (leave blank to keep current): ");
                    string title = Console.ReadLine();
                    if (!string.IsNullOrEmpty(title)) movie.Title = title;
                    Console.Write("Enter new director (leave blank to keep current): ");
                    string director = Console.ReadLine();
                    if (!string.IsNullOrEmpty(director)) movie.Director = director;
                    Console.Write("Enter new year (leave blank to keep current): ");
                    string yearInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(yearInput))
                        movie.Year = int.Parse(yearInput);
                    Console.WriteLine("Movie updated successfully!");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }
            static void RemoveMovie()
            {
                Console.Write("Enter movie ID to remove: ");
                int id = int.Parse(Console.ReadLine());
                Movie movie = movieList.Find(m => m.Id == id);
                if (movie != null)
                {
                    movieList.Remove(movie);
                    Console.WriteLine("Movie removed successfully.");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }
            static void DisplayAllMovies()
            {
                if (movieList.Count == 0)
                {
                    Console.WriteLine("No movies in the database.");
                    return;
                Console.WriteLine("Movies in your library:");
                foreach (Movie m in movieList)
                {
                    Console.WriteLine($"ID: {m.Id}, Title: {m.Title}, Director: {m.Director}, Year: {m.Year}");
                }
            }
        }
    }
}










                }













































           











































































