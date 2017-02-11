using System;
using System.Collections.Generic;

using Academy.Models.Utils.Contracts;
using Academy.Models.Contracts;
using Academy.Models.Common;
using Academy.Models.Enums;
using System.Text;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private const int MinStudentNameLength = 3;
        private const int MaxStudentNameLength = 16;

        private string username;
        private Track track;
        private IList<ICourseResult> courseResults;

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = (Track)Enum.Parse(typeof(Track), track);  // May couse a problem !
            this.courseResults = new List<ICourseResult>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "User's username should be between 3 and 16 symbols long!");
                Validator.CheckIfStringLengthIsValid(value, MaxStudentNameLength, MinStudentNameLength, "User's username should be between 3 and 16 symbols long!");
                this.username = value;
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                Validator.CheckIfNull(value, "The provided track is not valid!");
                Validator.CheckIfTrackIsValid(value, "The provided track is not valid!");
                this.track = value;
            }
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("* Student:");
            sb.AppendLine(string.Format(" - Username: {0}", this.Username));
            sb.AppendLine(string.Format(" - Track: {0}", this.Track));
            sb.AppendLine(string.Format(" - Course results: "));

            return sb.ToString();
        }
    }
}
