using CohortMidterm.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace MidTerm.Models
{
    [NotMapped]
    public class StudentAppContext : DbContext
    {
        public StudentAppContext() : base("name=StudentAppContext")
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }

    }
}