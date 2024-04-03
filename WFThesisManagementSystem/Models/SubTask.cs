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
    
    public partial class SubTask
    {
        public int subtask_id { get; set; }
        public string subtask_name { get; set; }
        public string subtask_description { get; set; }
        public Nullable<System.DateTime> open_day { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<System.DateTime> submit_day { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> task_id { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Task Task { get; set; }
    }
}