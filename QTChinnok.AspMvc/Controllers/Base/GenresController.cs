using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace QTChinnok.AspMvc.Controllers.Base
{
    public class GenresController : Controller
    {
        // GET: GenresController
        [HttpGet("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var entities = await ctrl.GetAllAsync();
            return View(entities.Select(e => Models.Base.Genre.Create(e)));
        }

        // GET: GenresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenresController/Create
        public ActionResult Create()
        {
            return View(new Models.Base.Genre());
        }

        // POST: GenresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Base.Genre model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        //// POST: GenresController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: GenresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenresController/Edit/5
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



        // GET: GenresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenresController/Delete/5
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
