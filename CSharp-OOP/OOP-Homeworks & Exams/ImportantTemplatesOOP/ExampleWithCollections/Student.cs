namespace ExampleWithCollections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public int Id { get; set; }

        public IEnumerable<Course> CoursesList { get; set; }  // ако ни трябва индексатор ползваме IList 

        public Student()
        {
            this.CoursesList = new List<Course>();  // може всякакви тупове колкции да му бласкаме 
        }
    }
}
