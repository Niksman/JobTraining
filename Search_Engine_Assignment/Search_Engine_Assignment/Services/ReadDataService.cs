using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using Search_Engine_Assignment.Base;
using Search_Engine_Assignment.Services;

namespace Search_Engine_Assignment {
	public class ReadDataService {
		public static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";
		public static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";
		public static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";
		public static string Pictures_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\pictures_csv.txt";

		public static string[] MoviesFileToStringArray { get => File.ReadAllLines(Movies_Path); }
		public static string[] PicturesFileToStringArray { get => File.ReadAllLines(Pictures_Path); }
		public static string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }
		public static string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }

		public List<Movie> movieList = new MovieMapperService().ConvertToList(MoviesFileToStringArray);
		public List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
		public List<Book> bookList = new BookMapperService().ConvertToList(BooksFileToStringArray);
		public List<Picture> pictureList = new PictureMapperService().ConvertToList(PicturesFileToStringArray);
		
	}

	//public class PictureMapperService : IMapper<string[], Picture> {
		
	//	public List<Picture> ConvertToList(string[] input) {
	//		input = ReadDataService.PicturesFileToStringArray; 

	//		var query = from line in input
	//					let data = line.Split(',')
	//					select new {
	//						Name = data[0],
	//						Description = data[1],
	//						Price = data[2],
	//						TimeAndDate = data[3],
	//						Owner = data[4]
	//					};

	//		var readListFromFile = new List<Picture>();

	//		foreach (var item in query) {
	//			readListFromFile.Add(new Picture(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.Owner));
	//}
	//		return readListFromFile;
	//	}
	//}

	//public class MovieMapperService : IMapper<string[], Movie> {

	//	public List<Movie> ConvertToList(string[] input) {
	//		input = ReadDataService.MoviesFileToStringArray;

	//		var query = from line in input
	//					let data = line.Split(',')
	//					select new {
	//						Name = data[0],
	//						Description = data[1],
	//						Price = data[2],
	//						TimeAndDate = data[3],
	//						MyReview = data[4]
	//					};

	//		var readListFromFile = new List<Movie>();

	//		foreach (var item in query) {
	//			readListFromFile.Add(new Movie(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.MyReview));
	//		}
	//		return readListFromFile;
	//	}

	//}

	//public class SongMapperService : IMapper<string[], Song> {

	//	public List<Song> ConvertToList(string[] input) {
	//		input = ReadDataService.SongsFileToStringArray;

	//		var query = from line in input
	//					let data = line.Split(',')
	//					select new {
	//						Name = data[0],
	//						Description = data[1],
	//						Price = data[2],
	//						TimeAndDate = data[3],
	//						Language = data[4]
	//					};

	//		var readListFromFile = new List<Song>();

	//		foreach (var item in query) {
	//			readListFromFile.Add(new Song(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.Language));
	//		}
	//		return readListFromFile;
	//	}
	//}

	//public class BookMapperService : IMapper<string[], Book> {

	//	public List<Book> ConvertToList(string[] input) {
	//		input = ReadDataService.BooksFileToStringArray;

	//		var query = from line in input
	//					let data = line.Split(',')
	//					select new {
	//						Name = data[0],
	//						Description = data[1],
	//						Price = data[2],
	//						TimeAndDate = data[3],
	//						Genre = data[4]
	//					};

	//		var readListFromFile = new List<Book>();

	//		foreach (var item in query) {
	//			readListFromFile.Add(new Book(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.Genre));
	//		}
	//		return readListFromFile;
	//	}
	//}
}
