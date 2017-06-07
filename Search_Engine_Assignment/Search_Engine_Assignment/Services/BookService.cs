using System.Collections.Generic;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class BookService : IReadableList<Book> {

		public List<Book> GetList() {
			List<Book> bookList = new Service().bookList;
			return bookList;
		}
	}
}
