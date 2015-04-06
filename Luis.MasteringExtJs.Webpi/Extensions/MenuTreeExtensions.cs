using System.Collections.Generic;
using System.Linq;
using Luis.MasteringExtJs.WebApi.Mapping;
using Luis.MasteringExtJs.WebApi.Models;

namespace Luis.MasteringExtJs.WebApi.Extensions
{
    public static class MenuTreeExtensions
    {
        public static List<MenuTree> BuildTree(this List<MenuFlat> source)
        {
            var groups = source.ToTree().GroupBy(i => i.MenuId);

            var roots = groups.FirstOrDefault(g => !g.Key.HasValue).ToList();

            if (roots.Count > 0)
            {                
                var dict = groups.Where(g => g.Key.HasValue).ToDictionary(g => g.Key.Value, g => g.ToList());
                for (var i = 0; i < roots.Count; i++)
                {
                    AddItems(roots[i], dict);
                }
            }

            return roots;
        }

        private static void AddItems(MenuTree node, IDictionary<int, List<MenuTree>> source)
        {
            if (source.ContainsKey(node.Id))
            {
                node.Items = source[node.Id];
                for (var i = 0; i < node.Items.Count; i++)
                {
                    AddItems(node.Items[i], source);
                }
            }
            else
            {
                //node.Items = new List<MenuTree>();
                node.Items = null;
            }
        }
    }
}