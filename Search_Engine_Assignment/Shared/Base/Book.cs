using System;

namespace Shared.Base {
	public class Book : MyBaseItemClass {

		public string Genre { get; set; }
		public int PageCount { get; set; }
		public string Description { get; set; }

		public Book(string name, string description, int pageCount, string genre) : base(name) {
			Description = description;
			PageCount = pageCount;
			Genre = genre;
		}

		public override string ToString() {
			//return string.Format("Name of the book is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\". " +
			//	"Genre is: \"{4}\"", Name, Description, TimeAndDate, Price, Genre);

			return string.Format($"Name of the book is \"{Name}\", description is \"{Description}\", page count is \"{PageCount}\" pages, genre is \"{Genre}\".");
		}
	}
}
