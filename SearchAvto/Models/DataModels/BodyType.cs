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
    
    public partial class BodyType
    {
        public BodyType()
        {
            this.CarModels = new HashSet<CarModel>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int BodyClassId { get; set; }
        public int BaseBodyTypeId { get; set; }
        public string Description { get; set; }
    
        public virtual BodyClass BodyClass { get; set; }
        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}
