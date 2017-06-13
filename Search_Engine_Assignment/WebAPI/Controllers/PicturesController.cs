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
	[Route("api/[controller]")]
	public class PicturesController : Controller {

		// GET api/pictures
		[HttpGet]
		public List<Picture> Get() {

			var items = new PictureService().GetList();

			return items;
		}
	}
}