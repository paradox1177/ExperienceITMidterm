using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CohortMidterm.Models
{
    public class Courses
    {
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        public string CourseDescription { get; set; }
        
        [Required]
        public string TutorName { get; set; }
        
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1-10")]
        public int CourseRating { get; set; }
    }
}