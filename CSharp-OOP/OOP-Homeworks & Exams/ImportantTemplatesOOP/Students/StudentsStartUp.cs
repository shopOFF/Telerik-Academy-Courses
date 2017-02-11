namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class StudentsStartUp
    {
        public static void Main()
        {
            // от абстракният клас директно няма как да си направим обект, защото той се имплементира в неговите наследници, можем да ползваме тях !!!
            var jns = new JuniorStudent();
            jns.Name = "Diego";
            Console.WriteLine(jns.GetAllCourses()); // извикваме си метода който принтира курсовете на junior-студентите

            var seniorStd = new SeniorStudent();
            seniorStd.Name = "Gerasim";
            Console.WriteLine(seniorStd.GetAllCourses());
        }
    }
}
