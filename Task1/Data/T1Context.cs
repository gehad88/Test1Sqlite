using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace Task1.Data
{
    class T1Context : DbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Task1.db");
        }
    }
}
