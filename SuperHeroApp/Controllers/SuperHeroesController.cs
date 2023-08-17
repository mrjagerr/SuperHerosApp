using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApp.Models;

namespace SuperHeroApp.Controllers
{
    public class SuperHeroesController : Controller
    {
        // GET: SuperHeroesController
        public ActionResult Index()
        {

            //Linq query to retrieve all the rows from the table
            var superheroes = "";
            return View();
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)
        {
            //Linq query to find specific row from table
            return View();
        }

        // GET: SuperHeroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                //Linq Add superhero to the list
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
