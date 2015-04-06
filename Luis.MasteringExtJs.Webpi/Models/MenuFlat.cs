using System.Collections.Generic;

namespace Luis.MasteringExtJs.WebApi.Models
{
    public class MenuFlat
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Iconcls { get; set; }
        public string ClassName { get; set; }
        public int? MenuId { get; set; }
                
        //public List<Permission> Permissions { get; set; }
    }
}