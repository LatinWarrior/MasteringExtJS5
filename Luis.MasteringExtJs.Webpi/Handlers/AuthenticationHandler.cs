using Luis.MasteringExtJs.WebApi.Repository;
using User = Luis.MasteringExtJs.WebApi.Models.User;

namespace Luis.MasteringExtJs.WebApi.Handlers
{    
    public interface IAuthenticationHandler
    {
        User Authenticate(User user);
    }

    public class AuthenticationHandler : IAuthenticationHandler
    {
        private readonly SakilaEntities _sakilaEntities;

        public AuthenticationHandler(SakilaEntities sakilaEntities)
        {
            _sakilaEntities = sakilaEntities;
        }

        public User Authenticate(User user)
        {
            return user;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }    
}