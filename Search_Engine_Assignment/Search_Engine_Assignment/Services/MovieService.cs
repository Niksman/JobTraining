﻿using System.Collections.Generic;
using System.IO;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class MovieService : IReadableList<Movie> {

		public List<Movie> GetList() {
			List<Movie> movieList = new MovieMapperService().ConvertToList(MoviesFileToStringArray);
			return movieList;
		}

		private static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";

		string[] MoviesFileToStringArray { get => File.ReadAllLines(Movies_Path); }
	}
}
