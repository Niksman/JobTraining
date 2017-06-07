using System.Collections.Generic;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class SongService : IReadableList<Song> {

		public List<Song> GetList() {
			List<Song> songList = new Service().songList;
			return songList;
		}
	}
}
