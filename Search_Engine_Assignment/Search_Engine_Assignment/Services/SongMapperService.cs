using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class SongMapperService : IMapper<string[], Song> {

		public List<Song> ConvertToList(string[] input) {
			input = ReadDataService.SongsFileToStringArray;

			var query = from line in input
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2],
							TimeAndDate = data[3],
							Language = data[4]
						};

			var readListFromFile = new List<Song>();

			foreach (var item in query) {
				readListFromFile.Add(new Song(item.Name, item.Description, Convert.ToInt32(item.Price), Convert.ToDateTime(item.TimeAndDate), item.Language));
			}
			return readListFromFile;
		}
	}
}
