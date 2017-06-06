using System;
using System.Collections.Generic;
using System.Text;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class SongService : IReadableList<Song> {

		public List<Song> GetList() {
			List<Song> songList = new ReadDataService().songList;
			return songList;
		}
	}
}
