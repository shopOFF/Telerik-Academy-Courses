namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        public School(ICollection<Student> students, ICollection<Course> courses)
        {
            this.Students = students;
            this.Courses = courses;
        }

        public ICollection<Student> Students { get; private set; }
        public ICollection<Course> Courses { get; private set; }

    }
}

