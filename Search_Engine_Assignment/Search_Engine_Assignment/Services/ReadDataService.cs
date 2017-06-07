//using System.Collections.Generic;
//using System.IO;
//using Search_Engine_Assignment.Base;
//using Search_Engine_Assignment.Services;

//namespace Search_Engine_Assignment {
//	public class ReadDataService {
//		public static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";
//		public static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";
//		public static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";
//		public static string Pictures_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\pictures_csv.txt";

//		public static string[] MoviesFileToStringArray { get => File.ReadAllLines(Movies_Path); }
//		public static string[] PicturesFileToStringArray { get => File.ReadAllLines(Pictures_Path); }
//		public static string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }
//		public static string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }
		
//		public List<Movie> movieList = new MovieMapperService().ConvertToList(MoviesFileToStringArray);
//		public List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
//		public List<Book> bookList = new BookMapperService().ConvertToList(BooksFileToStringArray);
//		public List<Picture> pictureList = new PictureMapperService().ConvertToList(PicturesFileToStringArray);
//	}
//}
