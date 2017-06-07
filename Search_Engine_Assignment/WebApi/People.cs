using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi {
	public class People {
		public string Name { get; set; }
		public string Surname { get; set; }

		public override string ToString() {
			return string.Format("Name is {0}, surname is {1}", Name, Surname);
		}
	}
}
