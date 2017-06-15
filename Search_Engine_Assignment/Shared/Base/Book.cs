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
			return string.Format($"Book name is \"{Name}\", description is \"{Description}\", page count is \"{PageCount}\" pages, genre is \"{Genre}\".");
		}
	}
}
