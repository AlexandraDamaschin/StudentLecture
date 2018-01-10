using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentLecture.Models.StudentLectureModels
{
    [Table("LectureSubject")]
    public class LectureSubject
    {
        [Key]
        [ForeignKey("assocSubject")]
        [Display(Name = "Subject ID")]
        public int SubjectId { get; set; }

        [Key]
        [ForeignKey("assocLecturer")]
        [Display(Name = "Lecture ID")]
        public int LectureId { get; set; }

        public virtual Subject assocSubject { get; set; }
        public virtual Lecture assocLecturer { get; set; }
    }
}