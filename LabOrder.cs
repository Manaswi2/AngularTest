//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class LabOrder
    {
        public int Id { get; set; }
        public int LabTestId { get; set; }
        public int PatientId { get; set; }
        public int FacilityId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal AmountBilled { get; set; }
        public decimal AmountCollected { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual LabTest LabTest { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
