using System;
using System.Collections.Generic;
using System.Text;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class BookService : IReadableList<Book> {

		public List<Book> GetList() {
			List<Book> bookList = new ReadDataService().bookList;
			return bookList;
		}
	}
}
