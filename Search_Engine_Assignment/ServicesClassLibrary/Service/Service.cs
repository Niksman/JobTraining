using System.Collections.Generic;
using DataAccess;
using ServicesClassLibrary.Base;

namespace ServicesClassLibrary.Service {
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
