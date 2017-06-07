using System.Collections.Generic;
using System.IO;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class SongService : IReadableList<Song> {

		public List<Song> GetList() {
			List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
			return songList;
		}

		public static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";

		public static string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }

		//public List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
	}
}
