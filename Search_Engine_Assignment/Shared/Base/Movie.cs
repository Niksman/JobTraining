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
		
		public override string ToString() {
			//return string.Format("Name of the movie is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
			//	" My personal review : \"{4}\"", Name, Description, TimeAndDate, Price, Review);

			return string.Format($"Name of the movie is \"{Name}\", description is \"{Description}\", length \"{Length}\" minutes, review \"{Review}\".");
		}
	}
}
