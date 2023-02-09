using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace QTChinnok.AspMvc.Controllers.Base
{
    public class GenresController : Controller
    {
        // GET: GenresController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var entities = await ctrl.GetAllAsync();
            return View(entities.Select(e => Models.Base.Genre.Create(e)));
        }

        // GET: GenresController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity!));
        }

        // GET: GenresController/Create
        public ActionResult Create()
        {
            return View(new Models.Base.Genre());
        }

        // POST: GenresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Models.Base.Genre model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.GenresController();
                var entity = new Logic.Models.Base.Genre { Name = model.Name };

                await ctrl.InsertAsync(entity);
                await ctrl.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
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
        public async Task<ActionResult> Edit(int id)
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity!));
        }

        // POST: GenresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Models.Base.Genre model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.GenresController();
                var entity = await ctrl.GetByIdAsync(id);

                if(entity != null)
                {
                    entity.Name = model.Name;
                    await ctrl.UpdateAsync(entity);
                    await ctrl.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }



        // GET: GenresController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity!));
        }

        // POST: GenresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Models.Base.Genre model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.GenresController();
                var entity = await ctrl.GetByIdAsync(id);

                if (entity != null)
                {
                    await ctrl.DeleteAsync(id);
                    await ctrl.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
