﻿using System;
using System.Collections.Generic;
using System.Linq;
using ServicesClassLibrary.Base;

namespace ServicesClassLibrary.Service {
	public class BookMapperService : IMapper<string[], Book> {

		public List<Book> ConvertToList(string[] input) {

			var query = from line in input
						let data = line.Split(',')
						select new Book(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToDateTime(data[3]), data[4]);

			return query.ToList();
		}
	}
}
