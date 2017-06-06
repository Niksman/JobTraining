using System;
using System.Collections.Generic;
using System.Text;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class PictureService : IReadableList<Picture> {

		public List<Picture> GetList() {
			List<Picture> pictureList = new ReadDataService().pictureList;
			return pictureList;
		}
	}
}
