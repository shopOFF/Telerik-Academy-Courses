namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Classes
    {
        private List<Student> studentsInClass;
        private List<Teacher> teachersInClass;
        private string classID;

        public Classes(List<Teacher> teachersInClass, List<Student> studentsInClass, string classID)
        {
            this.TeachersInClass = teachersInClass;
            this.StudentsInClass = studentsInClass;
            this.ClassID = classID;
        }


        public List<Teacher> TeachersInClass
        {
            get { return this.teachersInClass; }
            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("This class must have at least one teacher!");
                }
                else
                {
                    this.teachersInClass = value;
                }
            }
        }

        public List<Student> StudentsInClass
        {
            get { return this.studentsInClass; }
            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("This class must have at least one student!");
                }
                else
                {
                    this.studentsInClass = value;
                }
            }
        }

        public string ClassID
        {
            get { return this.classID; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid class ID!");
                }
                else
                {
                    this.classID = value;
                }
            }
        }
    }
}
