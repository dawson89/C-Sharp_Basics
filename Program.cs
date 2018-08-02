using System;

namespace Treehouse.FitnessFrog
{
	public class Program
	{
		static void Main()
		{
			// Prompt user for minutes exercised 
			Console.Write("Enter how many minutes you exercised: ");
			string entry = Console.ReadLine();

			// Add minutes exercised to total 
			// Display total minutes exercised to the screen 
			Console.WriteLine("You have exercised for " + entry + " minutes.");

			// Repeat until user quits    
		}
	}
}