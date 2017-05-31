using System;
using System.Collections.Generic;
using System.Text;

namespace Search_Engine_Assignment {
	public class Service {

		public List<Movie> movieList = new List<Movie>() {
			new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
			new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
			new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12)
		};

		public List<Song> songList = new List<Song>() {
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9)
		};

		public List<Book> bookList = new List<Book>() {
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};

		public List<MyBaseClass> AllTitlesList = new List<MyBaseClass>() {

			new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
			new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
			new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12),
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9),
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};




		public void ShowBooksList() {
			foreach (var item in bookList) {
				Console.WriteLine(item);
			}
		}

		public void ShowMoviesList() {
			foreach (var item in movieList) {
				Console.WriteLine(item);
			}
		}

		public void ShowSongsList() {
			foreach (var item in songList) {
				Console.WriteLine(item);
			}
		}


	}
}
