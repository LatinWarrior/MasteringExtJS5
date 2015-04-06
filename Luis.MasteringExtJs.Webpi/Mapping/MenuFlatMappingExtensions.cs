using System.Collections.Generic;
using AutoMapper;
using M = Luis.MasteringExtJs.WebApi.Models;
using R = Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi.Mapping
{
    public static class MenuFlatMappingExtensions
    {
        public static void Configure()
        {
            Mapper.CreateMap<M.MenuFlat, R.Menu>()
                .ForMember(dest => dest.Menu1, opt => opt.Ignore())
                .ForMember(dest => dest.Menu2, opt => opt.Ignore())
                .ForMember(dest => dest.Permissions, opt => opt.Ignore())
                ;
            Mapper.CreateMap<R.Menu, M.MenuFlat>()
                //.ForMember(dest => dest.Permissions, opt => opt.ResolveUsing(src => src.Permissions.ToDomain()))
                ;
        }

        public static M.MenuFlat ToDomain(this R.Menu menu)
        {
            return Mapper.Map<R.Menu, M.MenuFlat>(menu);
        }

        public static R.Menu ToRepository(this M.MenuFlat menu)
        {
            return Mapper.Map<M.MenuFlat, R.Menu>(menu);
        }

        public static List<M.MenuFlat> ToDomain(this ICollection<R.Menu> menus)
        {
            return Mapper.Map<ICollection<R.Menu>, List<M.MenuFlat>>(menus);
        }

        public static ICollection<R.Menu> ToRepository(this List<M.MenuFlat> menus)
        {
            return Mapper.Map<List<M.MenuFlat>, ICollection<R.Menu>>(menus);
        }
    }
}