using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CohortMidterm.Models
{
    public class Min18YrsOld : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime birthdate = Convert.ToDateTime(value);
            
            var age = DateTime.Today.Year - birthdate.Year;

           return (age > 18) ? true : false;
        }
    }
}