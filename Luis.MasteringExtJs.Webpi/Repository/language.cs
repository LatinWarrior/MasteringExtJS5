//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Luis.MasteringExtJs.WebApi.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class language
    {
        public language()
        {
            this.films = new HashSet<film>();
            this.films1 = new HashSet<film>();
        }
    
        public byte language_id { get; set; }
        public string name { get; set; }
        public System.DateTime last_update { get; set; }
    
        public virtual ICollection<film> films { get; set; }
        public virtual ICollection<film> films1 { get; set; }
    }
}
