namespace _03.ExtMethodsLambdaExprLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LINQExtenstionMethods
    {
        // ТОВА КОЕТО Е ВАЖНО ЗА ЕКСТЕНШЪН МЕТОДИТЕ, Е ЧЕ ТЕ ВИ ВРЪЩАТ НОВ ОБЕКТ, НОВА КОЛЕКЦИЯ(не презаписват старата)!!!! ЗАТОВА ТРЯБВА ДА ПРИСВОЙМ РЕЗУЛТАТ НА ДР.ЕТО ТАКА - var newListOfStudents = 

        // Where() - давате му някаква заявка, която искате да направи(var newListOfStudents = listOfStudents.Where(st=>st.FirstName.StartsWith("s")); - примерно)
        // First() / FirstOrDefault() - връща първият елемент от колекцията / връща първият елемент от колекцията, или дефоутната стойност.Примерно- var first = listOfStudents.FirstOrDefault(st => st.Mark > 2).ToList(); и тн.
        // Last() / LastOrDefault() - връща обратното на горното...
        // Select() / Cast() - позволяват ви да трансформирате оригиналните обекти в нещо друго - var lastNames = listOfStudents.Select(st => st.LastName).ToList(); и ще ни извади само последните имена на студентите. Cast- опитай се да ми ги кастенеш към нещо...за обекти става трудно...
        // OrderBy() / ThenBy() / OrderByDescending() - за подредби, var lastNames = listOfStudents.Where(st => st.Mark > 2).OrderBy(st => st.LastName).ThenBy(st => st.FirstName).ToList(); подреждаме ги по фамилия, ако има съвпадения във фамилиите, сортираме еднаквите по и по 1во име. 
        // OrderByDescending()- обръща на обратно получения резултат 
        // Всички екстеншън методи могат да се наслагват един над друг...

        // Any() - Искам да провея дали Някой изпълнява наккво условие(поне един) - var lastNames = listOfStudents.Any(st => st.Mark > 2) връща TRUE и FALSE    
        // All() - дали всички изпълняват дадено условие - var lastNames = listOfStudents.All(st => st.Mark > 2) връща TRUE и FALSE  
        // ToArray() / ToList() / AsEnumerable() -  var lastNames = listOfStudents.Where(st => st.Mark > 2).OrderBy(st => st.LatsName).ToList(); ЗА ДА РАБОТИМ С НЯКАКВА АДЕКВАТНА КОЛЕКЦИЯ,
        // КОЯТО ИМА ИНДЕКСАТОР И ТН КАТО ЛИСТА, ПОНЕЖЕ ТИЯ МЕТОДИ ВРЪЩАТ ПРОСТ НЯКАКВА БАЗОВА КОЛЕКЦИЯ, КОЯТО МОЖЕ САМО ДА СЕ FOREACH-ВА.
        // Reverse() - обръща дадена колекция...

        // НАВСЯКЪДЕ МОЖЕ И УСЛОВИЯ ДА СЕ НАБУХАТ В ЛАМБДАТА
        // Average() - var avarageMark = listOfStudents.Average(st => st.Mark) - връща средноаритметично
        // Count() - var avarageMark = listOfStudents.Count(st => st.Mark > 2) - ще преброй колко елемента има в колекцията(могат и разбира условия да му се набухат), но по големи от 2
        // Sum() - var avarageMark = listOfStudents.Sum(st => st.Mark) - ще ги сумира
        // Max() - var avarageMark = listOfStudents.Max(st => st.Mark) - максималната стойност в колекцията
        // Min() - var avarageMark = listOfStudents.Min(st => st.Mark) - минималната стойност в колекцията

        // Skip() / Take() - var groups = listOfStudents.Skip(2).Take(1).ToList(); Skip(2) - скипни ми първите 2, и Take(2) ми вземи следващите две...ТОВА Е МНОГО УДОБНО ПРИ (PAGING) КОГАТО ИМАМЕ БРОЕНЕ НА СТАНИЦИ, ПЕЙДЖИРАНЕ, ОТ ПЪРВА НА 3-ТА СТРАНИЦА И ТН...
        // SelectMany() - Ако имаме колекция от колекции, можем да ги флатнем(да ги направим на една колекция) със SelectMany().


        // Ще нафраскаме всички класове в един файл, кофти но... кот такоа, само мейн метода ще си бъде в стартЪпа
    }
    // Базов клас студент:
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return this.Id + "; Name: " + this.Name + "; Courses: " + this.Courses.Count;
        }
    }

    // Клас Курс
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    // Клас Студенстко репоситори(хранилище)
    public class StudentsRepository
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var csharp = new Course { Id = 2, Name = "CSharp" };
            var javaScript = new Course { Id = 3, Name = "JavaScript" };
            var students = new List<Student>
        {
            new Student
                {
                    Id = 1,
                    Name = "Ivan",
                    Courses = new List<Course> { oop, javaScript }
                },
            new Student
                {
                    Id = 2,
                    Name = "Gosho",
                    Courses =
                        new List<Course> { oop, javaScript, csharp }
                },
            new Student
                {
                    Id = 3,
                    Name = "Pesho",
                    Courses = new List<Course> { csharp, javaScript }
                },
        };

            return students;
        }
    }
}
