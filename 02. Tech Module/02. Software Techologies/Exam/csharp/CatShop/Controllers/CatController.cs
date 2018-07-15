namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            // TODO
            var cats = context.Cats.ToList();
            return View(cats);

        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            // TODO
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            // TODO
            context.Cats.Add(cat);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            // TODO
            Cat cat = context
                .Cats
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(cat);

        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            // TODO
            context.Cats.Update(catModel);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            // TODO
            Cat cat = context
               .Cats
               .Where(p => p.Id == id)
               .FirstOrDefault();

            return View(cat);


        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            // TODO
            context.Cats.Remove(catModel);
            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
