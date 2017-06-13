using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;

namespace ServicesClassLibrary.Service {
	public class BookService : IReadableList<Book> {

		public List<Book> GetList() {
			List<Book> bookList = new BookMapperService().ConvertToList(BooksFileToStringArray);
			return bookList;
		}

		private static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";

		string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }
	}
}
