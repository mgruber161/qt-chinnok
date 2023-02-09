using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QTChinnok.AspMvc.Controllers.Base
{
    public class ArtistsController : Controller
    {
        // GET: ArtistsController
        public async Task<ActionResult> Index()
        {
            using var ctrl = new Logic.Controllers.Base.ArtistsController();
            var entities = await ctrl.GetAllAsync();
            return View(entities.Select(e => Models.Base.Artist.Create(e)));
        }

        // GET: ArtistsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            using var ctrl = new Logic.Controllers.Base.ArtistsController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Artist.Create(entity!));
        }

        // GET: ArtistsController/Create
        public ActionResult Create()
        {
            return View(new Models.Base.Artist());
        }

        // POST: ArtistsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Models.Base.Artist model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.ArtistsController();
                var entity = new Logic.Models.Base.Artist { Name = model.Name };

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

        // GET: ArtistsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            using var ctrl = new Logic.Controllers.Base.ArtistsController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Artist.Create(entity!));
        }

        // POST: ArtistsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Models.Base.Artist model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.ArtistsController();
                var entity = await ctrl.GetByIdAsync(id);

                if (entity != null)
                {
                    entity.Name = model.Name;
                    await ctrl.UpdateAsync(entity);
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

        // GET: ArtistsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            using var ctrl = new Logic.Controllers.Base.ArtistsController();
            var entity = await ctrl.GetByIdAsync(id);
            return entity == null ? NotFound() : View(Models.Base.Artist.Create(entity!));
        }

        // POST: ArtistsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Models.Base.Artist model)
        {
            try
            {
                using var ctrl = new Logic.Controllers.Base.ArtistsController();
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
