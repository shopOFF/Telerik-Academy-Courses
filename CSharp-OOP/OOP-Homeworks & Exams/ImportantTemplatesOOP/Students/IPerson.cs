namespace Students
{
    using System.Collections.Generic;
    public interface IPerson
    {
        string Name { get; set; }  // ще си има име

        IEnumerable<string> Courses { get; }  // курсовете  // може да се налижи да ги изтрием от тук!!!

        string GetAllCourses();  // и метода за вс курсове
        
    }
}
