namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, string teacherName, IList<string> students)
        : base(name, teacherName, students)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
           : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            internal set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Town can not be null or empty!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");

            return result.ToString();
        }
    }
}