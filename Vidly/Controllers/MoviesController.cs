using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek!"};

            ViewData["Movie"] = movie;

            ViewBag.RandomMovie = movie;

            return View();

            //return View(movie);
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});


        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 0;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        //}


        [Route("movies/released/{year:regex(2015|2016)}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



        public ActionResult Pessoa()
        {
            var pessoa = new Pessoa(){Nome = "Pablo"};
            return View(pessoa);
        }


        public ActionResult ListaTurma(int serie,string turma)
        {
            return Content(String.Format("Alunos da {0} seria da turma {1}", serie, turma));
        }




        public ActionResult ActionJoao(int year)
        {
            return Content(String.Format("Total de pontos do João é {0}", year));
        }
    }
}