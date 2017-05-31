using System;
using System.Collections.Generic;

namespace Search_Engine_Assignment {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Type in something to search for in item names, or just hit enter to list all!");
			//	DisplaySearchedContent();
			DisplaySearchedContent_MyAlgorithm();

			Console.ReadLine();
		}

		private static void DisplaySearchedContent_MyAlgorithm() {
			var userInput = Console.ReadLine();
			var service = new Service();
			var sortedList = new List<MyBaseClass>();
			var list = service.AllTitlesList;
			foreach (var item in list) {
				if (DoesStringContainsSubstring(item.Name, userInput)) {
					sortedList.Add(item);
				}
			}
			foreach (var item in sortedList) {
				Console.WriteLine(item);
			}
		}

		public static bool DoesStringContainsSubstring(string name, string input) {
			bool result = true;

			if (input == null || name.ToLower().Contains(input.ToLower())) {
				result = true;
			}  else {
				result = false;
			}
			return result;
		}

		private static void DisplaySearchedContent() {
			string userInput = Console.ReadLine();

			var results = new Service().AllTitlesList.FindAll(x => x.Name.ToLower().Contains(userInput.ToLower()));
			foreach (var item in results) {
				Console.WriteLine(item);
			}
		}

	}
}