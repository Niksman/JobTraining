using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;
using Shared.Base;

namespace ServicesClassLibrary.Service {
	public class SongService : IReadableList<Song> {

		public List<Song> GetList() {
			//List<Song> songList = new SongMapperService().ConvertToList(SongsFileToStringArray);
			List<Song> songList = new List<Song>();
			return songList;
		}

		static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";

		string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }
	}
}
