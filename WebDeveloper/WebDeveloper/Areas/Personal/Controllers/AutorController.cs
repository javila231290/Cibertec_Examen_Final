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
    public class AutorController : Controller
    {
        private readonly RepositorioAutor _repositorioAutor;
        public AutorController(RepositorioAutor repositorioAutor)
        {
            _repositorioAutor = repositorioAutor;
        }

        [OutputCache(Duration = 0)]
        public ActionResult Index()
        {
            return View(_repositorioAutor.ObtenerLista());
        }

        public PartialViewResult Crear()
        {
            return PartialView("_Crear");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Autores autor)
        {
            if (!ModelState.IsValid) return PartialView("_Crear", autor);
            _repositorioAutor.Adicionar(autor);
            return new HttpStatusCodeResult(HttpStatusCode.OK); //RedirectToAction("Index");
        }

        [OutputCache(Duration = 0)]
        public ActionResult Editar(int id)
        {
            var autor = _repositorioAutor.ObtenerPorId(id);
            if (autor == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Editar", autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 0)]
        public ActionResult Editar(Autores autor)
        {
            if (!ModelState.IsValid) return PartialView("_Editar", autor);
            _repositorioAutor.Actualizar(autor);
            return RedirectToRoute("Personal_default");
        }


        [OutputCache(Duration = 0)]
        public ActionResult Eliminar(int id)
        {
            var autor = _repositorioAutor.ObtenerPorId(id);
            if (autor == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Eliminar", autor);
        }
    }
}