using System;

namespace Shared.Base {
	public abstract class MyBaseItemClass {
		public string Name { get; set; }
		public string AuthorName { get; set; }
		public string AuthorSurname { get; set; }

		public MyBaseItemClass(string name) {
			Name = name;
		}

		public MyBaseItemClass(string authorName, string authorSurname, string name) {
			AuthorName = authorName;
			AuthorSurname = authorSurname;
			Name = name;
		}
	}
}
