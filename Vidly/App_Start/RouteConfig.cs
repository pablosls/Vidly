using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();


            //routes.MapRoute(
            //    "RotaAlunos",
            //    "alunos/{id}",
            //    new {controller = "Alunos", action = "ListaAluno"}, 
            //    //new {id = @"\d{4}"});
            //    new {id = @"2015|2016"});


            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new {controller = "Movies", action = "ByReleaseDate" });

            //routes.MapRoute(
            //    "RotaDoPablo",
            //    "alunos/serie/{serie}/turma/{turma}",
            //    new { controller = "Movies", action = "ListaTurma" });


            //routes.MapRoute(
            //    "RotaJoao",
            //    "joao/{year}",
            //    new { controller = "Movies", action = "ActionJoao" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
