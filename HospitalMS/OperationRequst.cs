//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class OperationRequst
    {
        public int operationID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string PatientName { get; set; }
        public string FatherName { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public string Date { get; set; }
        public string PhysicianName { get; set; }
        public string OperatienDate { get; set; }
        public string AssignedPhysician { get; set; }
        public string Specification { get; set; }
    }
}
