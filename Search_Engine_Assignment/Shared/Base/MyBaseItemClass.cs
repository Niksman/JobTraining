using System;

namespace Shared.Base {
	public abstract class MyBaseItemClass {
		public string Name { get; set; }
		//public string Description { get; set; }
		//public int Price { get; set; }
		//public DateTime TimeAndDate { get; set; }

		public MyBaseItemClass(string name) {
			Name = name;
		}
	}
}
