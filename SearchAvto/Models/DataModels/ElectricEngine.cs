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
    
    public partial class ElectricEngine
    {
        public ElectricEngine()
        {
            this.Modifications = new HashSet<Modification>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ElectricMotorId1 { get; set; }
        public Nullable<int> ElectricMotorId2 { get; set; }
        public Nullable<int> BatteryTypeId { get; set; }
        public Nullable<int> BatteryNominalVoltage { get; set; }
    
        public virtual BatteryType BatteryType { get; set; }
        public virtual ElectricMotor ElectricMotor { get; set; }
        public virtual ElectricMotor ElectricMotor1 { get; set; }
        public virtual ICollection<Modification> Modifications { get; set; }
    }
}