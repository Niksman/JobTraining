using System.Collections.Generic;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class MovieService : IReadableList<Movie> {

		public List<Movie> GetList() {
			List<Movie> movieList = new ReadDataService().movieList;
			return movieList;
		}
	}
}
