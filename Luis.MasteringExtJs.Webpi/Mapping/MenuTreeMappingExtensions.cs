using System.Collections.Generic;
using AutoMapper;
using M = Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Mapping
{
    public static class MenuTreeMappingExtensions
    {
        public static void Configure()
        {
            Mapper.CreateMap<M.MenuFlat, M.MenuTree>()
                //.ForMember(dest => dest.IconCls, opt => opt.ResolveUsing(src => src.Iconcls))
                //.ForMember(dest => dest.Id, opt => opt.ResolveUsing(src => src.Id))
                .ForMember(dest => dest.IsLeaf, opt => opt.ResolveUsing(src => src.MenuId != null))
                //.ForMember(dest => dest.MenuId, opt => opt.ResolveUsing(src => src.MenuId))
                //.ForMember(dest => dest.Text, opt => opt.ResolveUsing(src => src.Text))
                .ForMember(dest => dest.Items, opt => opt.Ignore())
                ;
        }

        public static M.MenuTree ToTree(this M.MenuFlat menu)
        {
            return Mapper.Map<M.MenuFlat, M.MenuTree>(menu);
        }

        public static List<M.MenuTree> ToTree(this List<M.MenuFlat> menus)
        {
            return Mapper.Map<List<M.MenuFlat>, List<M.MenuTree>>(menus);
        }
    }
}