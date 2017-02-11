namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class SeniorStudent : Person
    {
        public override IEnumerable<string> Courses
        {
            get
            {
                return new List<string> { "ASP.NET", "JavaScript" };  // тука ще има повече курсове от джуниъра, по разб  причини 
            }
        }
    }
}
