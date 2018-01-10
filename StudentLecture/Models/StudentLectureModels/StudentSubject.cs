using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentLecture.Models.StudentLectureModels
{
    [Table("StudentSubject")]
    public class StudentSubject
    {
        [Key]
        [ForeignKey("assocStudent")]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; }

        [Key]
        [ForeignKey("assocSubject")]
        [Display(Name = "Subject ID")]
        public int SubjectId { get; set; }

        public virtual Student assocStudent { get; set; }
        public virtual Subject assocSubject { get; set; }
    }
}