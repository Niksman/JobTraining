using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Search_Engine_Assignment;
using Search_Engine_Assignment.Base;

namespace Search_Engine_Assignment.Services {
	public class Service {

		public List<MyBaseItemClass> GetAllTitlesList() {

			var AllTitlesList = new List<MyBaseItemClass>();

			AllTitlesList.AddRange(new MovieService().GetList());
			AllTitlesList.AddRange(new SongService().GetList());
			AllTitlesList.AddRange(new BookService().GetList());
			AllTitlesList.AddRange(new PictureService().GetList());

			return AllTitlesList;
		}
	}
}
