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
	[Route("api/Movies")]
	public class MoviesController : Controller {

		// GET api/movies
		[HttpGet]
		public List<Movie> Get() {

			List<Movie> items = new MovieService().GetList();

			return items;
		}
	}
}