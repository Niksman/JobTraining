using System;

namespace Search_Engine_Assignment.Base {
	public class Movie : MyBaseItemClass {

		public string MyReview { get; set; }

		public Movie(string name, string description, int price, DateTime timeAndDate, string myReview) : base(name, description, price, timeAndDate) {
			Name = name;
			Description = description;
			Price = price;
			TimeAndDate = timeAndDate;
			MyReview = myReview;
		}

		public override string ToString() {
			return string.Format("Name of the movie is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
				" My personal review : \"{4}\"", Name, Description, TimeAndDate, Price, MyReview);
		}
	}
}
