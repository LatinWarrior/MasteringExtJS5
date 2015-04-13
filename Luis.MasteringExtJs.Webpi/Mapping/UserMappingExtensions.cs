using System.Collections.Generic;
using AutoMapper;
using M = Luis.MasteringExtJs.WebApi.Models;
using R = Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi.Mapping
{
    public static class UserMappingExtensions
    {
        public static void Configure()
        {
            Mapper.CreateMap<M.User, R.User>()
                .ForMember(dest => dest.Group, opt => opt.Ignore())
                ;

            Mapper.CreateMap<R.User, M.User>()                
                ;
        }

        public static M.User ToDomain(this R.User user)
        {
            return Mapper.Map<R.User, M.User>(user);
        }

        public static R.User ToRepository(this M.User user)
        {
            return Mapper.Map<M.User, R.User>(user);
        }

        public static List<M.User> ToDomain(this ICollection<R.User> users)
        {
            return Mapper.Map<ICollection<R.User>, List<M.User>>(users);
        }

        public static ICollection<R.User> ToRepository(this List<M.User> users)
        {
            return Mapper.Map<List<M.User>, ICollection<R.User>>(users);
        }
    }
}