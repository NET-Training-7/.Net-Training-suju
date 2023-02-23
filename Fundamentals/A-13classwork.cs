using System;
//write a program to calculate remaining days for upcoming "Holi festival.
// Write try/catch blocks to handle possible error 
//and greet user with "Happy Holi" message no matter error occurs or not.
class Program
{
    public void Main()
    {
        try
        {
            DateTime holi = new DateTime(DateTime.Now.Year, 3, 29); // Set Holi date
            TimeSpan remaining = holi - DateTime.Now; // Calculate remaining time

            Console.WriteLine($"There are {remaining.Days} days remaining for Holi festival.");

            // Check if Holi has already passed this year
            if (remaining.TotalDays < 0)
            {
                Console.WriteLine("Sorry, Holi has already passed this year.");
            }
        }