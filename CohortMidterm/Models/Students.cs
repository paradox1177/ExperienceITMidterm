using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CohortMidterm.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Course Enrolled Date")]
        public DateTime? CourseEnrolledDate { get; set; }

        [Required]
        [Display(Name = "Course Status")]
        public int CourseStatus { get; set; }

        [Required]
        [Display(Name = "Grade")]
        public string Grade { get; set; }
        
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Birthdate is Required")]
        [Min18YrsOld(ErrorMessage = "Must be over 18")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

    }
}