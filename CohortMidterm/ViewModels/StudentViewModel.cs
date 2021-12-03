using CohortMidterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CohortMidterm.ViewModels
{
    public class StudentViewModel
    {
        public Students Student { get; set; }
        public List<Courses> CourseList { get; set; }
        public List<SelectListItem> CourseStatusList { get; set; }

        public StudentViewModel()
        {
            var statusList = new List<SelectListItem>();
            statusList.Add(new SelectListItem { Text = "In Progress", Value = "1" });
            statusList.Add(new SelectListItem { Text = "Completed", Value = "2" });
            CourseStatusList = statusList;

        }
    };
}