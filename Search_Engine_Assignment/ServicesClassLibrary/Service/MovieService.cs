using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;
using Shared.Base;
using DataAccess;

namespace ServicesClassLibrary.Service {
	public class MovieService : IReadableList<Movie> {

		public List<Movie> GetList() {
			List<Movie> movieList = new MoviesSqlRepository().GetList();
			return movieList;
		}

		private static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";

		string[] MoviesFileToStringArray { get => File.ReadAllLines(Movies_Path); }
	}
}
