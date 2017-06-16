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

		public Book(string authorName, string authorSurname, string name, string description, int pageCount, string genre) : base(authorName, authorSurname, name) {
			Description = description;
			PageCount = pageCount;
			Genre = genre;
		}

		public override string ToString() {
			return string.Format($"Author  \"{AuthorName} {AuthorSurname}\". Book \"{Name}\", description is \"{Description}\", page count is \"{PageCount}\" pages, genre is \"{Genre}\".");
		}
	}
}
