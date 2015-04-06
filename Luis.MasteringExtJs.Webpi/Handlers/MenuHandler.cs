using System.Collections.Generic;
using System.Linq;
using Luis.MasteringExtJs.WebApi.Mapping;
using D = Luis.MasteringExtJs.WebApi.Models;
using R = Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi.Handlers
{
    public interface IMenuHandler
    {
        List<D.MenuFlat> Get();
    }

    public class MenuHandler : IMenuHandler
    {
        private readonly R.SakilaEntities _sakilaEntities;

        public MenuHandler(R.SakilaEntities sakilaEntities)
        {
            _sakilaEntities = sakilaEntities;
        }

        public List<D.MenuFlat> Get()
        {
            var menus = _sakilaEntities.Menus.ToList().ToDomain();
            return menus;
        }
    }
}