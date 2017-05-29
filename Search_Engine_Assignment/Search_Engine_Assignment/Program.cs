using System;
using System.Collections.Generic;

namespace Search_Engine_Assignment
{
    class Program
    {
        static void Main(string[] args) {
			Console.WriteLine("Type in something to search for in item names:...");
			DisplaySearchedContent();

			Console.ReadLine();
		}

		private static void DisplaySearchedContent() {
			string userInput = Console.ReadLine();
			
			List<MyBaseClass> results = new Service().AllTitlesList.FindAll(x => x.Name.ToLower().Contains(userInput.ToLower()));

			foreach (var item in results) {
				Console.WriteLine(item);
			}
		}
	}
}