using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroApp.Data;
using SuperHeroApp.Models;

namespace SuperHeroApp.Controllers
{
    public class SuperHeroesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SuperHeroesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuperHeroesController
        public ActionResult Index()
        {
            //Linq query to retrieve all the rows from the table
            var superheroes = _context.SuperHeroes.ToList();

            return View(superheroes);
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)
        {
            //Linq query to find specific row from table
            var superhero = _context.SuperHeroes.Find(id);
            return View(superhero);
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

            if (ModelState.IsValid)
            {
                _context.SuperHeroes.Add(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(superHero);
        }

        // GET: SuperHeroesController/Edit/5
        public ActionResult Edit(int id)
        {
           var superhero=  _context.SuperHeroes.Find(id);

            return View(superhero);
        }

        // POST: SuperHeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {

            if (ModelState.IsValid)
            {
                _context.Entry(superHero).State=EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(superHero);
        }

        // GET: SuperHeroesController/Delete/5
        public ActionResult Delete(int ? id)
        {
            var superhero = _context.SuperHeroes.Find(id);
            return View(superhero);
        }

        // POST: SuperHeroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            
            
            if (ModelState.IsValid)
            {
                SuperHero superHero = _context.SuperHeroes.Find(id);
                _context.SuperHeroes.Remove(superHero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
               
            return View();
        }
    
    }
}
