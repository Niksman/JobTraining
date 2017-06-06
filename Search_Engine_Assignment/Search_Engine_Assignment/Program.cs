using System;
using System.Collections.Generic;
using System.Linq;
using Search_Engine_Assignment.Services;

namespace Search_Engine_Assignment {
	class Program {

		public static List<MyBaseItemClass> SearchedList;

		static void Main(string[] args) {
			Console.WriteLine("Type in something to search for in item names, or just hit enter to list all!");

			// Assignment_2();
			
			// ASSIGNMENT 3
			 Assignment_3();

			

			// ASSIGNMENT 1
			// DisplaySearchedContent_MyAlgorithm();

			Console.ReadLine();
		}

		private static void Assignment_2() {
			DisplayContentAssignment_2();
			ShowMovieList();
			ShowSongList();
			ShowBookList();
		}

		private static void Assignment_3() {
			SearchedList = DisplaySearchedContent_Linq();
			ShowDetailsDialog();
			OrderSearchedListChooser();
		}

		private static void ShowBookList() {
			Console.WriteLine("\n\tBooks:\n");
			var bList = new BookService().GetList();
			foreach (var item in bList) {
				Console.WriteLine(item);
			}
		}

		private static void ShowSongList() {
			Console.WriteLine("\n\tSongs:\n");
			var sList = new SongService().GetList();
			foreach (var item in sList) {
				Console.WriteLine(item);
			}
		}

		private static void ShowMovieList() {
			Console.WriteLine("\n\tMovies:\n");
			var mList = new MovieService().GetList();
			foreach (var item in mList) {
				Console.WriteLine(item);
			}
		}

		private static void DisplayContentAssignment_2() {
			Console.WriteLine("\tAll titles:\n");
			var allLists = new Service().GetAllTitlesList();
			foreach (var item in allLists) {
				Console.WriteLine(item);
			}
		}

		private static void ShowDetailsDialog() {
			Console.WriteLine("------------------------------------------------------------------------------");
			Console.WriteLine("\n\tSelect 1 to order all items by name ascending, \n\tSelect 2 to sort all prices ascending, \n\tSelect 3 to order all items by description length, \n\tSelect 4 to see all items price details, \n\tSelect 5 to quit:");
		}

		private static void OrderSearchedListChooser() {
			string input = Console.ReadLine().ToString();
			switch (input) {
				case "1":
					OrderItemsByName();
					break;
				case "2":
					SortAllPricesAndSum();
					break;
				case "3":
					OrderItemsByDescriptionLength();
					break;
				case "4":
					PriceDetails();
					break;
				case "5":

					break;
				default:
					Console.WriteLine("\nInvalid input! Choose again!");
					ShowDetailsDialog();
					OrderSearchedListChooser();
					break;
			}
		}

		private static void PriceDetails() {
			Console.WriteLine("\nPrice details:");
			var results = SearchedList.OrderBy(x => x.Price).ToList();

			var sum = results.Sum(x => x.Price);
			Console.WriteLine("\nSum of all items is: \"${0}\".", sum);

			var average = results.Average(x => x.Price);
			Console.WriteLine("\nAverage price for all items is: \"${0}\".", average);

			var cheapest = results.Min(x => x.Price);
			Console.WriteLine("\nCheapest item in the list is: \"${0}\".", cheapest);

			var mostExpensive = results.Max(x => x.Price);
			Console.WriteLine("\nMost expensive item in the list is: \"${0}\".", mostExpensive);
			ShowDetailsDialog();
			OrderSearchedListChooser();

		}

		private static void OrderItemsByDescriptionLength() {
			Console.WriteLine("\nSorted items by description length:\n");
			var results = SearchedList.OrderBy(x => x.Description.Length);
			foreach (var item in results) {
				Console.WriteLine(item);
			}
			ShowDetailsDialog();
			OrderSearchedListChooser();
		}

		private static void SortAllPricesAndSum() {
			Console.WriteLine("\nSorted items by price ascending:\n");
			var results = SearchedList.OrderBy(x => x.Price).ToList();
			foreach (var item in results) {
				Console.WriteLine(item);
			}
			ShowDetailsDialog();
			OrderSearchedListChooser();
		}

		private static void OrderItemsByName() {
			Console.WriteLine("\nSorted items by name ascending:\n");
			var results = SearchedList.OrderBy(x => x.Name).ToList();
			foreach (var item in results) {
				Console.WriteLine(item);
			}
			ShowDetailsDialog();
			OrderSearchedListChooser();
		}

		private static List<MyBaseItemClass> DisplaySearchedContent_Linq() {
			var userInput = Console.ReadLine();
			var newList = new List<MyBaseItemClass>();
			var results = new Service().GetAllTitlesList().Where(x => x.Name.ToLower().Contains(userInput.ToLower()));

			foreach (var item in results) {
				Console.WriteLine(item);
				newList.Add(item);
			}
			Console.WriteLine("\nSorted list contains {0} items.", results.Count());

			return newList;
		}

		//Methods used for assignment 1
		//private static void DisplaySearchedContent_MyAlgorithm() {
		//	var userInput = Console.ReadLine();
		//	var service = new Service();
		//	var searchedList = new List<MyBaseItemClass>();
		//	var list = service.GetAllTitlesList();

		//	foreach (var item in list) {
		//		if (DoesStringContainsSubstring(item.Name, userInput)) {
		//			searchedList.Add(item);
		//		}

		//	}
		//	foreach (var item in searchedList) {
		//		Console.WriteLine(item);
		//	}

		//	Console.WriteLine("\nSorted list contains {0} items.", searchedList.Count);
		//}

		//public static bool DoesStringContainsSubstring(string name, string input) {
		//	bool result = true;

		//	if (input == null || name.ToLower().Contains(input.ToLower())) {
		//		result = true;      // returns all items if input is empty
		//	} else {
		//		result = false;
		//	}
		//	return result;
		//}


	}
}