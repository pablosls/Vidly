using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaAluno(int id)
        {
            //return Content(String.Format("Retornando o aluno id {0}", id));

            var aluno = new Aluno(){Nome = "Pablo", Id = 1};
            
            return View(aluno);
        }

        
    }
}