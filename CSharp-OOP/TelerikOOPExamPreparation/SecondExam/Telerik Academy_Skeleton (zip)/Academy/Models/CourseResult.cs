using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Common;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private const int MinExamPoints = 0;
        private const int MaxExamPoint = 1000;
        private const int MinCoursePoints = 0;
        private const int MaxCoursePoint = 125;

        private readonly ICourse course;
        private readonly float examPoints;
        private readonly float coursePoints;
        private Grade grade;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            Validator.ValidateFloatRange(float.Parse(examPoints), MinExamPoints, MaxExamPoint, "Course result's exam points should be between 0 and 1000!");
            Validator.ValidateFloatRange(float.Parse(coursePoints), MinCoursePoints, MaxCoursePoint, "Course result's course points should be between 0 and 125!");

            this.course = course;
            this.examPoints = float.Parse(examPoints);
            this.coursePoints = float.Parse(coursePoints);

            if (this.examPoints >= 65 || this.coursePoints >= 75)
            {
                this.grade = Grade.Excellent;
            }
            else if ((this.examPoints < 60 && this.examPoints >= 30) || (this.coursePoints < 75 && this.coursePoints >= 45))
            {
                this.grade = Grade.Passed;
            }
            else
            {
                this.grade = Grade.Failed;
            }
        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.examPoints;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" - Course results:");
            sb.AppendLine(string.Format("  * {0}: Points - {1}, Grade - {2}", this.Course,this.CoursePoints,this.Grade)); 

            return sb.ToString();
        }
    }
}
