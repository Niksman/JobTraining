using System;
using System.Collections.Generic;
using System.Linq;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class BookMapperService : IMapper<string[], Book> {

		public List<Book> ConvertToList(string[] input) {
			input = Service.BooksFileToStringArray;

			var query = from line in input
						let data = line.Split(',')
						select new Book(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToDateTime(data[3]), data[4]);

			return query.ToList();
		}
	}
}
