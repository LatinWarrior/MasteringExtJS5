using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Luis.MasteringExtJs.WebApi.Handlers;
using Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    public class AuthenticationController : ApiController
    {
        private readonly IAuthenticationHandler _authenticationHandler;

        public AuthenticationController(IAuthenticationHandler authenticationHandler)
        {
            _authenticationHandler = authenticationHandler;
        }

        // POST: api/Authentication
        [ResponseType(typeof (User))]
        public IHttpActionResult Authenticate(User user)
        {
            var result = _authenticationHandler.Authenticate(user);
            return Ok(result);
        }
    }
}