//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public Nullable<int> CourseCost { get; set; }
    }
}
