namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Person, IComment
    {
        private int classNumber;

        private List<string> comment= new List<string>();


        public Student(string firstName, string lastName, int classNumber) 
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return classNumber;
            }

            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid Class Number!");
                }
                else
                {
                    classNumber = value;
                }
                
            }
        }

        public List<string> Comment
        {
            get
            {
                return this.comment;
            }
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public string ShowComments()
        {
            var result = string.Empty;
            for (int i = 0; i < comment.Count; i++)
            {
                result += comment[i] + "\n\r";
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1}, Class Number: {2}", this.FirstName, this.LastName, this.ClassNumber);
        }
    }
}
