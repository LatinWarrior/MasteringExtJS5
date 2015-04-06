using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Luis.MasteringExtJs.WebApi.Handlers;
using Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        private readonly IAuthenticationHandler _authenticationHandler;

        public AuthenticationController(IAuthenticationHandler authenticationHandler)
        {
            _authenticationHandler = authenticationHandler;
        }

        // POST: api/Authentication
        [Route("")]
        [ResponseType(typeof (AuthTicket))]
        public IHttpActionResult Authenticate(User user)
        {
            var result = _authenticationHandler.Authenticate(user);

            if (user.UserName != "luis")
            {
                return (NotFound());
            }

            var authTicket = new AuthTicket
            {
                Msg = "User Authenticated",
                Success = true,
                Ticket = new Guid().ToString(),
                Authenticated = true
            };

            return Ok(authTicket);
        }

        // POST: api/Authentication/logout
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            var authTicket = new AuthTicket
            {
                Authenticated = false,
                Success = true,
            };

            return Ok(authTicket);
        }

        [Route("KeepAlive/{token}")]
        public IHttpActionResult KeepAlive(string token)
        {
            return Ok();
        }
    }
}