
using System;
using NLog.Web;
using System.IO;
using System. Linq;

namespace MediaLibrary
{
    class Program
    {
        // create static instance of Logger
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        static void Main(string[] args)
        {

            logger.Info("Program started");

            Console.WriteLine("1) Add a Movie");

            Console.WriteLine("2) Display all Movies");

            Console.WriteLine(" 3) Perform a search");

            string scrubbedFile = FileScrubber.ScrubMovies("movies.csv");
            logger.Info(scrubbedFile);
            MovieFile movieFile = new MovieFile(scrubbedFile);

            Console.ForegroundColor = ConsoleColor.Green;

            var Movies = movieFile.Movies.Where(m=>m.title.Contains("(1990)"));

            Console.WriteLine($"There are {Movies.Count ()} movies from 1990");

            Console.ForegroundColor = ConsoleColor.White;
             
            logger.Info("Program ended");
        }
    }
}