using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoriasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();



        // GET: Categorias
        public ActionResult Index()
        {
            var categorias = db.Categorias.ToList();
            return View(categorias);
        }
    }
}