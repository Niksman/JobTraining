using System;

namespace Search_Engine_Assignment {
	public abstract class MyBaseItemClass {
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public DateTime TimeAndDate { get; set; }

		public MyBaseItemClass(string name, string description, int price, DateTime timeAndDate) {
			Name = name;
			Description = description;
			Price = price;
			TimeAndDate = timeAndDate;
		}
	}

	//public class Picture : MyBaseItemClass {

	//	public string Owner { get; set; }

	//	public Picture(string name, string description, int price, DateTime timeAndDate, string differentField) : base(name, description, price, timeAndDate) {
	//		Name = name;
	//		Description = description;
	//		Price = price;
	//		TimeAndDate = timeAndDate;
	//		Owner = differentField;
	//	}

	//	public override string ToString() {
	//		return string.Format("Name of the picture is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
	//			" Diff field: \"{4}\"", Name, Description, TimeAndDate, Price, Owner);
	//	}
	//}

	//public class Movie : MyBaseItemClass {

	//	public string MyReview { get; set; }

	//	public Movie(string name, string description, int price, DateTime timeAndDate, string myReview) : base(name, description, price, timeAndDate) {
	//		Name = name;
	//		Description = description;
	//		Price = price;
	//		TimeAndDate = timeAndDate;
	//		MyReview = myReview;
	//	}

	//	public override string ToString() {
	//		return string.Format("Name of the movie is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
	//			" My personal review : \"{4}\"", Name, Description, TimeAndDate, Price, MyReview);
	//	}
	//}

	//public class Song : MyBaseItemClass {

	//	public string Language { get; set; }

	//	public Song(string name, string description, int price, DateTime timeAndDate, string language) : base(name, description, price, timeAndDate) {
	//		Name = name;
	//		Description = description;
	//		Price = price;
	//		TimeAndDate = timeAndDate;
	//		Language = language;
	//	}

	//	public override string ToString() {
	//		return string.Format("Name of the song is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
	//			"Language : \"{4}\"", Name, Description, TimeAndDate, Price, Language);
	//	}
	//}

	//public class Book : MyBaseItemClass {

	//	public string Genre { get; set; }

	//	public Book(string name, string description, int price, DateTime timeAndDate, string genre) : base(name, description, price, timeAndDate) {
	//		Name = name;
	//		Description = description;
	//		Price = price;
	//		TimeAndDate = timeAndDate;
	//		Genre = genre;
	//	}

	//	public override string ToString() {
	//		return string.Format("Name of the book is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\". " +
	//			"Genre is: \"{4}\"", Name, Description, TimeAndDate, Price, Genre);
	//	}
	//}
}
