using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrangeRe.Models;
using OrangeRe.Models.Recipes;
using Trio.BAL;

namespace OrangeRe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Connection con = new Connection();
            List<Details> detil = con.details.ToList();
            return View(detil);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult ReadMore()
        {
            ViewBag.Message = "Read more about Orange.";
            return View();
        }
        public ActionResult Trade()
        {
            ViewBag.Message = "Know about Orange traders.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Know about the creature.";

            return View();
        }

        
        public ActionResult Recipes()
        {
            ViewBag.Message = "Your orange recipes.";
            Connection con = new Connection();
            List<Recipes> rec = con.Recipes.ToList();
            return View(rec);
        }
       

        [HttpGet]
        public ActionResult Create()
        {
            return View();

            //foreach(string key in formCollection)
            //{
            //    Response.Write("key = " + key + " ");
            //    Response.Write(formCollection[key]);
            //    Response.Write("<br/>");
            //}
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [HttpPost]
        public ActionResult Create(Recipes model)
        {

            Recipes res = new Recipes();
            Registration reg = new Registration();
            if (ModelState.IsValid)
            {
                res.RecipesName = model.RecipesName;
                res.Description = model.Description;
                res.RecipesImg = model.RecipesImg;
                reg.Proc_Orange_RecipeInsert(res);
                return RedirectToAction("Recipes");
            }
            else
            {
                return RedirectToAction("Create");
            }
            //res.RecipesName = formCollection["RecipesName"];
            //res.Description = formCollection["Description"];
            //res.RecipesImg = formCollection["RecipesImg"];
            //return View();
        }



    }
}