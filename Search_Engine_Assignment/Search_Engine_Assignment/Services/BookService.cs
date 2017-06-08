using System.Collections.Generic;
using System.IO;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class BookService : IReadableList<Book> {

		public List<Book> GetList() {
			List<Book> bookList = new BookMapperService().ConvertToList(BooksFileToStringArray);
			return bookList;
		}

		private static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";

		string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }
	}
}
