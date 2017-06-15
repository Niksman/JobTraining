using System;

namespace Shared.Base {
	public class Song : MyBaseItemClass {

		public string Language { get; set; }

		public Song(string name, string description, int price, DateTime timeAndDate, string language) : base(name, description, price, timeAndDate) {
			Language = language;
		}

		public override string ToString() {
			return string.Format("Name of the song is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
				"Language : \"{4}\"", Name, Description, TimeAndDate, Price, Language);
		}
	}
}
