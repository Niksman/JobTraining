using System;

namespace Shared.Base {
	public class Movie : MyBaseItemClass {

		public string Review { get; set; }
		public int Length { get; set; }
		public string Description { get; set; }

		public Movie(string name, string description, int length, string review) : base(name) {
			Description = description;
			Length = length;
			Review = review;
		}

		public Movie(string authorName, string authorSurname, string name, string description, int length, string review) : base(authorName, authorSurname, name) {
			Description = description;
			Length = length;
			Review = review;
		}

		public override string ToString() {
			return string.Format($"Author  \"{AuthorName} {AuthorSurname}\". Movie \"{Name}\", description is \"{Description}\", length \"{Length}\" minutes, review \"{Review}\".");
		}
	}
}
