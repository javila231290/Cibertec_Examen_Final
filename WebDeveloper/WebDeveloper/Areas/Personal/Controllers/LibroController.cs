using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Areas.Personal.Controllers
{
    [Authorize]
    public class LibroController : Controller
    {
        private readonly RepositorioLibro _repositorioLibro;
        public LibroController(RepositorioLibro repositorioLibro)
        {
            _repositorioLibro = repositorioLibro;
        }

        [OutputCache(Duration = 0)]
        public ActionResult Index()
        {            
            return View(_repositorioLibro.ObtenerLista());
        }

        public PartialViewResult Crear()
        {
            return PartialView("_Crear");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Libros libro)
        {
            if (!ModelState.IsValid) return PartialView("_Crear", libro);
            _repositorioLibro.Adicionar(libro);
            return new HttpStatusCodeResult(HttpStatusCode.OK); //RedirectToAction("Index");
        }

        [OutputCache(Duration = 0)]
        public ActionResult Editar(int id)
        {
            var libro = _repositorioLibro.ObtenerPorId(id);
            if (libro == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Editar", libro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 0)]
        public ActionResult Editar(Libros libro)
        {
            if (!ModelState.IsValid) return PartialView("_Editar", libro);
            _repositorioLibro.Actualizar(libro);
            return RedirectToRoute("Personal_default");
        }


        [OutputCache(Duration = 0)]
        public ActionResult Eliminar(int id)
        {
            var libro = _repositorioLibro.ObtenerPorId(id);
            if (libro == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Eliminar", libro);
        }
    }
}