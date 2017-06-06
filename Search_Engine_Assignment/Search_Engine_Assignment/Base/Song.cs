using System;

namespace Search_Engine_Assignment.Base {
	public class Song : MyBaseItemClass {

		public string Language { get; set; }

		public Song(string name, string description, int price, DateTime timeAndDate, string language) : base(name, description, price, timeAndDate) {
			Name = name;
			Description = description;
			Price = price;
			TimeAndDate = timeAndDate;
			Language = language;
		}

		public override string ToString() {
			return string.Format("Name of the song is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
				"Language : \"{4}\"", Name, Description, TimeAndDate, Price, Language);
		}
	}
}
