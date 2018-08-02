using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.FitnessFrog
{
	class Program
	{
		static void Main(string[] args)
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
