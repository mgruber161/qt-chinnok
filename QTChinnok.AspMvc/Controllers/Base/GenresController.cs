using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QTChinnok.AspMvc.Controllers.Base
{
    public class GenresController : Controller
    {
        private List<Models.Base.Genre> dataList = new List<Models.Base.Genre>();
        public GenresController()
        {
            dataList.AddRange(new Models.Base.Genre[]
            {
                new Models.Base.Genre
                {
                    Id = 1,
                    Name = "Synthpop"
                },
                new Models.Base.Genre
                {
                    Id = 2,
                    Name = "Darkwave"
                },
                new Models.Base.Genre
                {
                    Id = 3,
                    Name = "Synthwave"
                },
            });
        }
        // GET: GenresController
        public ActionResult Index()
        {
            return View(dataList);
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
        public ActionResult Create(IFormCollection collection)
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
