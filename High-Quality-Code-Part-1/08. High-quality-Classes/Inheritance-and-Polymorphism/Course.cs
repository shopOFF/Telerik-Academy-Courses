namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public abstract class Course : ICourse
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            internal set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be valid!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            internal set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher name must be valid!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            internal set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of students cannot be null!");
                }

                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
