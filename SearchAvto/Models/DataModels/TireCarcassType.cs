//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchAvto.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TireCarcassType
    {
        public TireCarcassType()
        {
            this.Modifications = new HashSet<Modification>();
        }
    
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
    
        public virtual ICollection<Modification> Modifications { get; set; }
    }
}