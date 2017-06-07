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
			var sList = new SongService().GetList();
			var bList = new BookService().GetList();
			var pList = new PictureService().GetList();
			AllTitlesList.AddRange(mList);
			AllTitlesList.AddRange(sList);
			AllTitlesList.AddRange(bList);
			AllTitlesList.AddRange(pList);
			
			return AllTitlesList;
		}

		//public static string Movies_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt";
		//public static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";
		//public static string Books_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt";
		//public static string Pictures_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\pictures_csv.txt";

		//public static string[] MoviesFileToStringArray { get => File.ReadAllLines(Movies_Path); }
		//public static string[] PicturesFileToStringArray { get => File.ReadAllLines(Pictures_Path); }
		//public static string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }
		//public static string[] BooksFileToStringArray { get => File.ReadAllLines(Books_Path); }

		//public List<Movie> movieList = new MovieMapperService().ConvertToList(MoviesFileToStringArray);
		//public List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
		//public List<Book> bookList = new BookMapperService().ConvertToList(BooksFileToStringArray);
		//public List<Picture> pictureList = new PictureMapperService().ConvertToList(PicturesFileToStringArray);
	}
}
