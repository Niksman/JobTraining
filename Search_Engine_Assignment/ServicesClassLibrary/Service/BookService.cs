using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;
using Shared.Base;
using DataAccess;

namespace ServicesClassLibrary.Service {
	public class BookService : IReadableList<Book> {

		public List<Book> GetList() {
			var bookList = new BooksSqlRepository().GetList();
			return bookList;
		}

		//for mapper
		//private static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";
		//string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }
	}
}
