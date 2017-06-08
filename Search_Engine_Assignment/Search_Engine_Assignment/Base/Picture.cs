using System;

namespace Search_Engine_Assignment.Base {
	public class Picture : MyBaseItemClass {

		public string Owner { get; set; }

		public Picture(string name, string description, int price, DateTime timeAndDate, string owner) : base(name, description, price, timeAndDate) {
			Owner = owner;
		}

		public override string ToString() {
			return string.Format("Name of the picture is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
				" Owner: \"{4}\"", Name, Description, TimeAndDate, Price, Owner);
		}
	}
}
