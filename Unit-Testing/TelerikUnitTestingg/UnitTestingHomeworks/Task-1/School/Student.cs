namespace School
{
    using System;
    public class Student
    {

        private string name;

        private int uniqueStudentNumber;

        public Student(string name, int uniqueSNumber)
        {
            this.Name = name;
            this.UniqueStudentNumber = uniqueSNumber;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public int UniqueStudentNumber
        {
            get { return this.uniqueStudentNumber; }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Unique student number should be between 10000 and 99999");
                }
                this.uniqueStudentNumber = value;
            }
        }
    }
}
