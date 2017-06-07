using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Search_Engine_Assignment;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class Service {

		public List<MyBaseItemClass> GetAllTitlesList() {
			var AllTitlesList = new List<MyBaseItemClass>();
			var mList = new MovieService().GetList();
			foreach (var item in mList) {
				AllTitlesList.Add(new Movie(item.Name, item.Description, item.Price, item.TimeAndDate, item.MyReview));
			}
			var sList = new SongService().GetList();
			foreach (var item in sList) {
				AllTitlesList.Add(new Song(item.Name, item.Description, item.Price, item.TimeAndDate, item.Language));
			}
			var bList = new BookService().GetList();
			foreach (var item in bList) {
				AllTitlesList.Add(new Book(item.Name, item.Description, item.Price, item.TimeAndDate, item.Genre));
			}
			var pList = new PictureService().GetList();
			foreach (var item in pList) {
				AllTitlesList.Add(new Picture(item.Name, item.Description, item.Price, item.TimeAndDate, item.Owner));
			}
			return AllTitlesList;
		}

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
}
