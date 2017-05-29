using System;
using System.Collections.Generic;
using System.Text;

namespace Search_Engine_Assignment
{
	public abstract class MyBaseClass {
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public abstract ChooseType Type { get; }

		public MyBaseClass(string name, string description, int price) {
			Name = name;
			Description = description;
			Price = price;
		}
	
	}

	// Zasto sam trebao da pravim ovo?
	public enum ChooseType {
			Unknown,
			Movie,
			Song,
			Book
	}

	public class Movie : MyBaseClass {
		
		public override ChooseType Type => ChooseType.Movie;

		public Movie(string name, string description, int price) : base(name, description, price) {
			Name = name;
			Description = description;
			Price = price;
		}

		public override string ToString() {
			return string.Format("Name of the movie is \"{0}\", description is \"{1}\". Buy it on Amazon for price \"${2}\".", Name, Description, Price);
		}
	}

	public class Song : MyBaseClass {

		public override ChooseType Type => ChooseType.Song;

		public Song(string name, string description, int price) : base(name, description, price) {
			Name = name;
			Description = description;
			Price = price;
		}

		public override string ToString() {
			return string.Format("Name of the song is \"{0}\", description is \"{1}\". Buy it on Amazon for price \"${2}\".", Name, Description, Price);
		}
	}

	public class Book : MyBaseClass {

		public override ChooseType Type => ChooseType.Book;

		public Book(string name, string description, int price) : base(name, description, price) {
			Name = name;
			Description = description;
			Price = price;
		}

		public override string ToString() {
			return string.Format("Name of the book is \"{0}\", description is \"{1}\". Buy it on Amazon for price \"${2}\".", Name, Description, Price);
		}
	}
}
