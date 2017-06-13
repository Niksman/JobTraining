using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesClassLibrary.Base;
using ServicesClassLibrary.Service;

namespace WebAPI.Controllers {
	[Produces("application/json")]
	[Route("api/Songs")]
	public class SongsController : Controller {

		// GET api/songs
		[HttpGet]
		public List<Song> Get() {

			List<Song> items = new SongService().GetList();

			return items;
		}
	}
}