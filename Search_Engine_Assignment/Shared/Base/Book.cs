using System;

namespace ServicesClassLibrary.Base {
	public class Book : MyBaseItemClass {

		public string Genre { get; set; }

		public Book(string name, string description, int price, DateTime timeAndDate, string genre) : base(name, description, price, timeAndDate) {
			Genre = genre;
		}

		public override string ToString() {
			return string.Format("Name of the book is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\". " +
				"Genre is: \"{4}\"", Name, Description, TimeAndDate, Price, Genre);
		}
	}
}
