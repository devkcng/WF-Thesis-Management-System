//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFThesisManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubtaskPoint
    {
        public int subtaskpoint_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> subtask_id { get; set; }
        public Nullable<double> subtask_point { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual SubTask SubTask { get; set; }
    }
}