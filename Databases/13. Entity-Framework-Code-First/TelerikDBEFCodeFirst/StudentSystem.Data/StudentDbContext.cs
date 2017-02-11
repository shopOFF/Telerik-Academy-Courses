﻿using System.Data.Entity;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext()
            :base("StudentDatabase")
        {

        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }
    }
}
