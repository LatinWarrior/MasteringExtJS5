using System.Collections.Generic;
using AutoMapper;
using M = Luis.MasteringExtJs.WebApi.Models;
using R = Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi.Mapping
{
    public static class PermissionMappingExtensions
    {
        public static void Configure()
        {
            Mapper.CreateMap<M.Permission, R.Permission>()
                .ForMember(dest => dest.Menu, opt => opt.Ignore())                
                ;
            Mapper.CreateMap<R.Permission, M.Permission>()                
                ;
        }

        public static M.Permission ToDomain(this R.Permission permission)
        {
            return Mapper.Map<R.Permission, M.Permission>(permission);
        }

        public static R.Permission ToRepository(this M.Permission permission)
        {
            return Mapper.Map<M.Permission, R.Permission>(permission);
        }

        public static List<M.Permission> ToDomain(this ICollection<R.Permission> permissions)
        {
            return Mapper.Map<ICollection<R.Permission>, List<M.Permission>>(permissions);
        }

        public static ICollection<R.Permission> ToRepository(this List<M.Permission> permissions)
        {
            return Mapper.Map<List<M.Permission>, ICollection< R.Permission>>(permissions);
        }
    }
}