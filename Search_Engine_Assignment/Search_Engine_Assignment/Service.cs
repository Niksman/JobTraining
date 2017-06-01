using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search_Engine_Assignment {
	public class Service {

		public List<MyBaseItemClass> AllTitlesList = new List<MyBaseItemClass>() {

			new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
			new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
			new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12),
			new Movie("Godzilla", "Gentle monster that doesn't exist, killed by human", 14),
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9),
			new Song("Paradise", "Sounds like a song which everyone likes", 11),
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Hacker", "Some guy named hacker, hacked something important. Cool", 18),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};

		public List<MyBaseItemClass> AllTitlesList = new List<MyBaseItemClass>() {

	public class MovieService<T> : IReadableList<T> {
		public List<Movie> movieList = new List<Movie>() {
			new Movie("Matrix", "American fiction movie where Keanu Reevs kicks some badasses", 10),
			new Movie("Titanic", "American heart braking story of Leonadro DiCaprio and Kate Winslet", 8),
			new Movie("Lepa sela lepo gore", "Serbian movie about war in near history, which I haven't watched", 12),
			new Movie("Godzilla", "Gentle monster that doesn't exist, killed by human", 14),
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9),
			new Song("Paradise", "Sounds like a song which everyone likes", 11),
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Hacker", "Some guy named hacker, hacked something important. Cool", 18),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};
		
		public List<T> GetList<T>() {
			throw new NotImplementedException();
		}
		
		public void ShowMoviesList() {
			foreach (var item in movieList) {
				Console.WriteLine(item);
			}
		}
	}

	public class SongService<T> : IReadableList<T>{
		public List<Song> songList = new List<Song>() {
			new Song("Lalala", "Made up song which could easily exist somewhere in the world", 3),
			new Song("Thriller", "Popular song from Michael Jackson, which made him famous", 6),
			new Song("Buffalo soldier", "Popular Bob Marley's song which pot smokers like the most", 9)
		};

		public List<T> GetList<T>() {
			throw new NotImplementedException();
		}

		public void ShowSongsList() {
			foreach (var item in songList) {
				Console.WriteLine(item);
			}
		}
	}

	public class BookService<T> : IReadableList<T> {
		public List<Book> bookList = new List<Book>() {
			new Book("Knife", "Serbian polititian actually wrote a book", 15),
			new Book("War", "Pretty sure that some book with this name does exist", 16),
			new Book("Z as zombie", "There isnt any Z letter in other names, so it should be easy to find in search engine", 17)
		};

		public List<T> GetList<T>() {
			throw new NotImplementedException();
		}

		public void ShowBooksList() {
			foreach (var item in bookList) {
				Console.WriteLine(item);
			}
		}
	}
}
