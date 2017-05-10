using Academy.Models;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Fakes
{
    public class FakeCourse : Course
    {
        public FakeCourse(string name, int lecturesPerWeek, DateTime? starting, DateTime? ending)
            : base(name, lecturesPerWeek, starting, ending)
        {
        }

        public IList<ILecture> ExposedLectures
        {
            get
            {
                return base.Lectures;
            }
        }
    }
}
