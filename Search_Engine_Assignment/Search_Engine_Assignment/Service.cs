using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search_Engine_Assignment {
	public class Service {

		public List<MyBaseItemClass> GetAllTitlesList() {
			var AllTitlesList = new List<MyBaseItemClass>();
			var mList = new MovieService().GetList();
			foreach (var item in mList) {
				AllTitlesList.Add(new Movie(item.Name, item.Description, item.Price));
			}
			var sList = new SongService().GetList();
			foreach (var item in sList) {
				AllTitlesList.Add(new Song(item.Name, item.Description, item.Price));
			}
			var bList = new BookService().GetList();
			foreach (var item in bList) {
				AllTitlesList.Add(new Book(item.Name, item.Description, item.Price));
			}
			return AllTitlesList;
		}
	}

	public class MovieService : IReadableList<Movie> {

		List<Movie> movieList = new ReadDataService().movieList;

		public List<Movie> GetList() {
			var mList = new List<Movie>();
			foreach (var item in movieList) {
				mList.Add(item);
			}
			return mList;
		}

		public void ShowMoviesList() {
			foreach (var item in movieList) {
				Console.WriteLine(item);
			}
		}
	}

	public class SongService : IReadableList<Song> {

		List<Song> songList = new ReadDataService().songList;

		public List<Song> GetList() {
			var sList = new List<Song>();
			foreach (var item in songList) {
				sList.Add(item);
			}
			return sList;
		}

		public void ShowSongsList() {
			foreach (var item in songList) {
				Console.WriteLine(item);
			}
		}
	}

	public class BookService : IReadableList<Book> {

		List<Book> bookList = new ReadDataService().bookList;

		public List<Book> GetList() {
			var bList = new List<Book>();
			foreach (var item in bookList) {
				bList.Add(item);
			}
			return bList;
		}

		public void ShowBooksList() {
			foreach (var item in bookList) {
				Console.WriteLine(item);
			}
		}
	}
}
