using System;
using System.Collections.Generic;
using System.Text;

namespace Search_Engine_Assignment {
	public abstract class MyBaseItemClass {
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }

		public MyBaseItemClass(string name, string description, int price) {
			Name = name;
			Description = description;
			Price = price;
		}

	}

	public class Movie : MyBaseItemClass {

		public Movie(string name, string description, int price) : base(name, description, price) {
			Name = name;
			Description = description;
			Price = price;
		}

		public override string ToString() {
			return string.Format("Name of the movie is \"{0}\", description is \"{1}\". Buy it on Amazon for price \"${2}\".", Name, Description, Price);
		}
	}

	public class Song : MyBaseItemClass {

		public Song(string name, string description, int price) : base(name, description, price) {
			Name = name;
			Description = description;
			Price = price;
		}

		public override string ToString() {
			return string.Format("Name of the song is \"{0}\", description is \"{1}\". Buy it on Amazon for price \"${2}\".", Name, Description, Price);
		}
	}

	public class Book : MyBaseItemClass {

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
