using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Search_Engine_Assignment
{
    class ReadDataService
    {
		public string Movies_Path { get { return @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\movies_csv.txt"; } }
		public string Songs_Path { get { return @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt"; } }
		public string Books_Path { get { return @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\books_csv.txt"; } }

		public List<MyBaseItemClass> ReadMoviesFromFile(string filePath) {
			string[] allLines = File.ReadAllLines(filePath);

			var query = from line in allLines
						let data = line.Split(',')
						select new {
							Name = data[0],
							Description = data[1],
							Price = data[2]
						};

			List<MyBaseItemClass> readListFromFile = new List<MyBaseItemClass>();

			foreach (var item in query) {
				
				if (filePath!=null && filePath.Equals(Movies_Path)) {
					readListFromFile.Add(new Movie(item.Name, item.Description, Convert.ToInt32(item.Price)));
				}
				if (filePath != null && filePath.Equals(Songs_Path)) {
					readListFromFile.Add(new Song(item.Name, item.Description, Convert.ToInt32(item.Price)));
				}
				if (filePath != null && filePath.Equals(Books_Path)) {
					readListFromFile.Add(new Book(item.Name, item.Description, Convert.ToInt32(item.Price)));
				}
			}

			foreach (var item in readListFromFile) {
				Console.WriteLine(item);
			}
			return readListFromFile;
		}
	}
}
