using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTViDuMVCGiaiPTBac1.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

    
        public virtual DbSet<Person> Persons { get;set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
           
    //        modelBuilder.Entity<>()
    //          .Property(e => e.StudentID)
    //          .IsUnicode(false);
    //        modelBuilder.Entity<Student>()
    //         .Property(e => e.StudentName)
    //         .IsUnicode(false);

    //    }
    }
}
