using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Base {
	public class Porn : MyBaseItemClass {
		public string PornStar { get; set; }
		public int Duration { get; set; }
		public int Rating { get; set; }

		public Porn(string name, string pornStar, int duration, int rating) : base(name) {
			PornStar = pornStar;
			Duration = duration;
			Rating = rating;
		}

		public Porn(string authorName, string authorSurname, string name, string pornStar, int duration, int rating) : base(authorName, authorSurname, name) {
			PornStar = pornStar;
			Duration = duration;
			Rating = rating;
		}

		public override string ToString() {
			return string.Format($"Author  \"{AuthorName} {AuthorSurname}\". Porn \"{Name}\", starring \"{PornStar}\", duration \"{Duration}\" minutes, and rating is \"{Rating}\".");
		}
	}
}
