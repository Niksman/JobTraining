using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI {
	public class Employee {

		public string Name { get; set; }
		public string Surname { get; set; }

		public Employee(string name, string surname) {
			Name = name;
			Surname = surname;
		}

		public override string ToString() {
			return string.Format("My name is {0}, and my surname is {1}.", Name, Surname);
		}
	}
}
