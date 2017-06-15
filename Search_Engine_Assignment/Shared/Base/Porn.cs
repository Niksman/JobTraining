using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Base {
	class Porn : MyBaseItemClass {
		public string PornStar { get; set; }
		public int Duration { get; set; }
		public int Rating { get; set; }

		public Porn(string name, string description, int price, DateTime timeAndDate, string pornStar, int duration, int rating) : base(name, description, price, timeAndDate) {
			PornStar = pornStar;
			Duration = duration;
			Rating = rating;
		}

		public override string ToString() {
			return string.Format($"Name of the porn is {Name}, starring {PornStar}, duration {Duration}, and rating is {Rating}");
		}
	}
}
