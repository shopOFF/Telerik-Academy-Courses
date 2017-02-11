using System;
using System.Collections.Generic;

using Academy.Models.Common;
using Academy.Models.Contracts;
using System.Text;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private const int MinCourseNameLength = 3;
        private const int MaxCourseNameLength = 45;
        private const int MinLecturesPerWeek = 1;
        private const int MaxLecturesPerWeek = 7;

        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<IStudent> onsiteStudents;
        private IList<IStudent> onlineStudents;
        private IList<ILecture> lectures;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
            this.onsiteStudents = new List<IStudent>();
            this.onlineStudents = new List<IStudent>();
            this.lectures = new List<ILecture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The name of the course must be between 3 and 45 symbols!");
                Validator.CheckIfStringLengthIsValid(value, MaxCourseNameLength, MinCourseNameLength, "The name of the course must be between 3 and 45 symbols!");
                this.name = value;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                Validator.ValidateIntRange(value, MinLecturesPerWeek, MaxLecturesPerWeek, "The number of lectures per week must be between 1 and 7!");
                this.lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                this.startingDate = value;
            }
        }

        public DateTime EndingDate
        {
            get
            {
                return this.endingDate;
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("* Course:");
            sb.AppendLine(string.Format(" - Name: {0}", this.Name));
            sb.AppendLine(string.Format(" - Lectures per week: {0}", this.LecturesPerWeek));
            sb.AppendLine(string.Format(" - Starting date: {0}", this.StartingDate));
            sb.AppendLine(string.Format(" - Ending date: {0}", this.EndingDate));
            sb.AppendLine(string.Format(" - Onsite students: {0}", this.OnsiteStudents.Count));
            sb.AppendLine(string.Format(" - Online students: {0}", this.OnlineStudents.Count));

            return sb.ToString();
        }
    }
}
