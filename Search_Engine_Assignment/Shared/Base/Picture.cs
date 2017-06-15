using System;

namespace Shared.Base {
	public class Picture : MyBaseItemClass {

		public string Owner { get; set; }
		public string Description { get; set; }

		public Picture(string name, string description, string owner) : base(name) {
			Description = description;
			Owner = owner;
		}

		public override string ToString() {
			return string.Format("Name of the picture is \"{0}\", description is \"{1}\", production date: \"{2}\". Buy it on Amazon for price \"${3}\"." +
				" Owner: \"{4}\"", Name, Description, Owner);
		}
	}
}
