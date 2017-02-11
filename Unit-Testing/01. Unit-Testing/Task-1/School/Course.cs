namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private ICollection<Student> studentsList;

        public Course()
        {
            this.StudentsList = new List<Student>();
        }

        public ICollection<Student> StudentsList
        {
            get { return this.studentsList; }
            protected set { this.studentsList = value; }
        }

        public void AddStudentToCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null!");
            }

            if (StudentsList.Count < 29)
            {
                if (StudentsList.Contains(student))
                {
                    throw new ArgumentException("The same student can not be added more than once!");
                }
                this.StudentsList.Add(student);

                return;
            }
            throw new ApplicationException("Students in a course must be less than 30!");
        }
        public void RemoveStudentFromCourse(Student student)
        {
            if (StudentsList.Contains(student))
            {
                this.StudentsList.Remove(student);
            }
            else
            {
                throw new ArgumentException("Student must joint the course first in order to be removed later on!");
            }
        }
    }
}
