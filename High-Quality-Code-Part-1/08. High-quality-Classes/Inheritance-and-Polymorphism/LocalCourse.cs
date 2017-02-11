namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
           : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            internal set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lab can not be null or empty!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse { Name = ");
            result.Append(base.ToString());
            result.Append("; Lab = ");
            result.Append(this.Lab);
            result.Append(" }");

            return result.ToString();
        }
    }
}