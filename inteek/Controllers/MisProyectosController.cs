using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class MisProyectosController : Controller
    {
        //
        // GET: /MisProyectos/
        public ActionResult Index()
        {
            return PartialView("Index");
        }
	}
}