using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;
using Shared.Base;
using DataAccess;

namespace ServicesClassLibrary.Service {
	public class SongService : IReadableList<Song> {

		public List<Song> GetList() {
			var songList = new SongsSqlRepository().GetList();
			return songList;
		}

		//for mapper
		//static string Songs_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\songs_csv.txt";
		//string[] SongsFileToStringArray { get => File.ReadAllLines(Songs_Path); }
	}
}
