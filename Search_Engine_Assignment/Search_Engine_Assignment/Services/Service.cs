using System;
using System.Collections;
using System.Collections.Generic;
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
	}

	//public class PictureService : IReadableList<Picture> {

	//	public List<Picture> GetList() {
	//		List<Picture> pictureList = new ReadDataService().pictureList;
	//		return pictureList;
	//	}
	//}

	//public class MovieService : IReadableList<Movie> {
		
	//	public List<Movie> GetList() {
	//	List<Movie> movieList = new ReadDataService().movieList;
	//		return movieList;
	//	}
	//}

	//public class SongService : IReadableList<Song> {

	//	public List<Song> GetList() {
	//	List<Song> songList = new ReadDataService().songList;
	//		return songList;
	//	}
	//}

	//public class BookService : IReadableList<Book> {

	//	public List<Book> GetList() {
	//	List<Book> bookList = new ReadDataService().bookList;
	//		return bookList;
	//	}
	//}
}
