namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExcercises;
        private List<string> comment = new List<string>();

        public Discipline(string disciplineName, int numberOfLectures, int numberOfExcercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public string DisciplineName
        {
            get { return disciplineName; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid Discipline Name!");
                }
                else
                {
                    disciplineName = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Number of Lectures!");
                }
                else
                {
                    numberOfLectures = value;
                }
            }
        }

        public int NumberOfExcercises
        {
            get { return numberOfExcercises; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Number of Excercises!");
                }
                else
                {
                    numberOfExcercises = value;
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

        public override string ToString()
        {
            return string.Format("Discipline: {0} | Number of lectures: {1} | Number of excercises: {2}", this.DisciplineName, this.NumberOfLectures, this.NumberOfExcercises);
        }
    }
}
