using System;

namespace Shared.Base {
	public abstract class MyBaseItemClass {
		public string Name { get; set; }

		public MyBaseItemClass(string name) {
			Name = name;
		}
	}
}
