using System;
using System.Collections.Generic;
using System.Linq;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class PictureMapperService : IMapper<string[], Picture> {

		public List<Picture> ConvertToList(string[] input) {
			input = ReadDataService.PicturesFileToStringArray;

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2],
							TimeAndDate = data[3],
							DifferentField = data[4]
						};

			var readListFromFile = new List<Picture>();

			foreach (var item in query) {
				readListFromFile.Add(new Picture(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.DifferentField));
			}
			return readListFromFile;
		}
	}
}
