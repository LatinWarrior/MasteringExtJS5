using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Luis.MasteringExtJs.WebApi.Handlers;
using Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class UsersController : ApiController
    {
        private readonly IUserHandler _userHandler;

        public UsersController(IUserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpGet]
        [Route("users")]
        public async Task<IHttpActionResult> GetUsers()
        {
            var users = await _userHandler.GetUsers();

            if (users == null ||
                users.Count == 0)
                return NotFound();

            return Ok(users);            
        }

        [HttpGet]
        [Route("users/{id:int}")]
        public async Task<IHttpActionResult> GetUser(int id)
        {
            var user = await _userHandler.GetUser(id);

            if (user == null)
                return NotFound();

            return Ok(user); ;
        }

        [HttpPost]
        [Route("users")]
        public async Task<IHttpActionResult> PostUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var newUser = await _userHandler.AddUser(user);
            return CreatedAtRoute("DefaultApi", new { id = newUser.Id }, newUser);
        }

        [HttpPut]
        [Route("users/{id:int}")]
        public async Task<IHttpActionResult> PutUser(int id, User user)
        {
            if (user == null ||
                user.Id != id)
            {
                return BadRequest();
            }            

            var updatedUser = await _userHandler.UpdateUser(id, user);

            if (updatedUser == null)
                return NotFound();

            return Ok(updatedUser);
        }

        [HttpDelete]
        [Route("users/{id:int}")]
        public async Task<IHttpActionResult> DeleteUser(int id)
        {
            var user = await _userHandler.DeleteUser(id);

            return Ok(user);
        }

        //// GET: api/Users
        //public IQueryable<User> GetUsers()
        //{
        //    return db.Users;
        //}        

        //// GET: api/Users/5
        //[ResponseType(typeof(User))]
        //public async Task<IHttpActionResult> GetUser(int id)
        //{
        //    User user = await db.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(user);
        //}

        //// PUT: api/Users/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutUser(int id, User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
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

        //// POST: api/Users
        //[ResponseType(typeof(User))]
        //public async Task<IHttpActionResult> PostUser(User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Users.Add(user);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
        //}

        //// DELETE: api/Users/5
        //[ResponseType(typeof(User))]
        //public async Task<IHttpActionResult> DeleteUser(int id)
        //{
        //    User user = await db.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Users.Remove(user);
        //    await db.SaveChangesAsync();

        //    return Ok(user);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool UserExists(int id)
        //{
        //    return db.Users.Count(e => e.Id == id) > 0;
        //}
    }
}