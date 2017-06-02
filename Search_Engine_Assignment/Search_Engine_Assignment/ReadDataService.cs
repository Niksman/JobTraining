using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Search_Engine_Assignment
{
    class ReadDataService
    {
		public static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";
		public static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";
		public static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";  

		public List<Movie> movieList = new MovieMapperService().ConvertToList(Movies_Path);
		public List<Song> songList = new SongMapperService().ConvertToList(Songs_Path);
		public List<Book> bookList = new BookMapperService().ConvertToList(Books_Path);

		//public List<MyBaseItemClass> ReadMoviesFromFile(string filePath) {
		//	string[] allLines = File.ReadAllLines(filePath);

		//	var query = from line in allLines
		//				let data = line.Split(',')
		//				select new {
		//					Name = data[0],
		//					Description = data[1],
		//					Price = data[2]
		//				};

		//	var readListFromFile = new List<MyBaseItemClass>();

		//	foreach (var item in query) {

		//		if (filePath!=null && filePath.Equals(Movies_Path)) {
		//			readListFromFile.Add(new Movie(item.Name, item.Description, Convert.ToInt32(item.Price)));
		//		}
		//		if (filePath != null && filePath.Equals(Songs_Path)) {
		//			readListFromFile.Add(new Song(item.Name, item.Description, Convert.ToInt32(item.Price)));
		//		}
		//		if (filePath != null && filePath.Equals(Books_Path)) {
		//			readListFromFile.Add(new Book(item.Name, item.Description, Convert.ToInt32(item.Price)));
		//		}
		//	}

		//	foreach (var item in readListFromFile) {
		//		Console.WriteLine(item);
		//	}
		//	return readListFromFile;
		//}

	}

	public class MovieMapperService : IMapper<string, Movie> {

		public List<Movie> ConvertToList(string filePath) {
			string[] input = File.ReadAllLines(filePath);
			

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2]
						};

			var readListFromFile = new List<Movie>();
			
				foreach (var item in query) {
					readListFromFile.Add(new Movie(item.Name, item.Description, Convert.ToInt32(item.Price)));
			
			}
			return  readListFromFile;
		}
		
	}

	public class SongMapperService : IMapper<string, Song> {
		
		public List<Song> ConvertToList(string filePath) {
			string[] input = File.ReadAllLines(filePath);

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2]
						};

			var readListFromFile = new List<Song>();

			foreach (var item in query) {
				readListFromFile.Add(new Song(item.Name, item.Description, Convert.ToInt32(item.Price)));
			}
			return readListFromFile;
		}
	}

	public class BookMapperService : IMapper<string, Book> {
		
		public List<Book> ConvertToList(string filePath) {
			string[] input = File.ReadAllLines(filePath);

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2]
						};

			var readListFromFile = new List<Book>();

			foreach (var item in query) {
				readListFromFile.Add(new Book(item.Name, item.Description, Convert.ToInt32(item.Price)));
			}
			return readListFromFile;
		}
	}
}
