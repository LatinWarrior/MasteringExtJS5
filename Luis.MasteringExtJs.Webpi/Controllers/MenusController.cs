using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Luis.MasteringExtJs.WebApi.Extensions;
using Luis.MasteringExtJs.WebApi.Handlers;
using Luis.MasteringExtJs.WebApi.Mapping;
using Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class MenusController : ApiController
    {
        //private readonly SakilaEntities _db = new SakilaEntities();
        private readonly IMenuHandler _menuHandler;

        public MenusController(IMenuHandler menuHandler)
        {
            _menuHandler = menuHandler;
        }

        // GET: api/Menus
        [Route("Menus")]
        public List<MenuTree> GetMenus()
        {
            return _menuHandler.Get().BuildTree();
        }

        //// GET: api/Menus/5
        //[ResponseType(typeof(Menu))]
        //public async Task<IHttpActionResult> GetMenu(int id)
        //{
        //    Menu menu = await _db.Menus.FindAsync(id);
        //    if (menu == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(menu);
        //}

        //// PUT: api/Menus/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutMenu(int id, Menu menu)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != menu.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _db.Entry(menu).State = EntityState.Modified;

        //    try
        //    {
        //        await _db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MenuExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Menus
        //[ResponseType(typeof(Menu))]
        //public async Task<IHttpActionResult> PostMenu(Menu menu)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _db.Menus.Add(menu);

        //    try
        //    {
        //        await _db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (MenuExists(menu.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = menu.Id }, menu);
        //}

        //// DELETE: api/Menus/5
        //[ResponseType(typeof(Menu))]
        //public async Task<IHttpActionResult> DeleteMenu(int id)
        //{
        //    Menu menu = await _db.Menus.FindAsync(id);
        //    if (menu == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.Menus.Remove(menu);
        //    await _db.SaveChangesAsync();

        //    return Ok(menu);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool MenuExists(int id)
        //{
        //    return _db.Menus.Count(e => e.Id == id) > 0;
        //}
    }
}