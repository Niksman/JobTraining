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
}
