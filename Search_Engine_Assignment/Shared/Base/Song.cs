using System;

namespace Shared.Base {
	public class Song : MyBaseItemClass {

		public int Duration { get; set; }
		public string Genre { get; set; }

		public Song(string name, int duration, string genre) : base(name) {
			Duration = duration;
			Genre = genre;
		}

		public Song(string authorName, string authorSurname, string name, int duration, string genre) : base(authorName, authorSurname, name) {
			Duration = duration;
			Genre = genre;
		}

		public override string ToString() {
			return string.Format($"Author  \"{AuthorName} {AuthorSurname}\". Song \"{Name}\", duration is \"{Duration}\" seconds, genre is \"{Genre}\".");
		}
	}
}
