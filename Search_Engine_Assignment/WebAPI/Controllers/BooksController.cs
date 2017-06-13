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
	public class BooksController : Controller {

		// GET api/books
		[HttpGet]
		public List<Book> Get() {

			var items = new BookService().GetList();

			return items;
		}
	}
}