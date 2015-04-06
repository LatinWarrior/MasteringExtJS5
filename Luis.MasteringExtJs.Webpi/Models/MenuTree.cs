using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Luis.MasteringExtJs.WebApi.Models
{
    [DataContract]
    public class MenuTree
    {
        [DataMember(EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Text { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string IconCls { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ClassName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? MenuId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsLeaf { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<MenuTree> Items { get; set; }
    }
}