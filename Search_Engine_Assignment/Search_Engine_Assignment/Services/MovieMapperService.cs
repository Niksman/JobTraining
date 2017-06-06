using System;
using System.Collections.Generic;
using System.Linq;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class MovieMapperService : IMapper<string[], Movie> {

		public List<Movie> ConvertToList(string[] input) {
			input = ReadDataService.MoviesFileToStringArray;

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2],
							TimeAndDate = data[3],
							MyReview = data[4]
						};

			var readListFromFile = new List<Movie>();

			foreach (var item in query) {
				readListFromFile.Add(new Movie(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.MyReview));
			}
			return readListFromFile;
		}

	}
}
