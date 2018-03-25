using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
		public ActionResult Detail()
		{
			//Returns to root page if the day matches
			if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
			{
				return Redirect("/");
			}

			//Displays on the pageComicBooks/Detail
			return Content("Hello from the Comic Books Controller");

		}
    }
}