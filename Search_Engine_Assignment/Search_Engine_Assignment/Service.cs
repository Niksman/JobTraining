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
		
		//public List<MyBaseItemClass> AllTitlesList = new List<MyBaseItemClass>() {

		//	new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
		//	new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
		//	new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12),
		//	new Movie("Godzilla", "Gentle monster that doesn't exist, killed by human", 14),
		//	new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
		//	new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
		//	new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9),
		//	new Song("Paradise", "Sounds like a song which everyone likes", 11),
		//	new Book("Knife", "Serbian polititian actually wrote a book", 15),
		//	new Book("War", "Pretty sure that some book with this name does exist", 16),
		//	new Book("Hacker", "Some guy named hacker, hacked something important. Cool", 18),
		//	new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		//};


	}

	public class MovieService : IReadableList<Movie> {
		public List<Movie> movieList = new List<Movie>() {
		new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
			new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
			new Movie("Godzilla", "Gentle monster that doesn't exist, killed by human", 14),
			new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12)
		};

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

	public class SongService : IReadableList<Song>{
		public List<Song> songList = new List<Song>() {
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Paradise", "Sounds like a song which everyone likes", 11),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9)
		};

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
		public List<Book> bookList = new List<Book>() {
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Hacker", "Some guy named hacker, hacked something important. Cool", 18),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};

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
