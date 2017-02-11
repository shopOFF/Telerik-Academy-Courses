namespace _03.ExtMethodsLambdaExprLinq
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using ExtensionMethods;

    #region Delegates
    //ТОВА Е ОСТАРЯЛ НАЧИН ЗА ПИСАНЕ НА ДЕЛЕГАТИ !!!!!!!!!!!
    public delegate void SimpleDelegate(string param); // ето така ... искам един делегат който да ми пази стринг
    #endregion
    public class StartUpExamples
    {
        public static void Main()
        {
            #region ExtensionMethods
            var text = "Pesho Gosho Petran";        // искаме директно да ни брой думите в стринга без да пишем вс път метод, а като натисме точка да ни излиза този екст.метод които е глобален за цялото приложение
            var wordCount = text.CountWords();  // след като ни е готов екст. метода, след като напишем text. и вече ни излиза екст. метода,И Е ВИДИМ И ЗА ВСИЧКО В ТОЗИ НЕЙМСПЕЙС,ЗА ВСИЧКИ ДРУГИ ПРОМЕНЛИВИ ОТ ТИП СТРИНГ И МОЖЕМ ДА СИ ГО ПОЛЗВАМЕ!!!!НО НЕ Е ГЛОБАЛНО ЗА ЦЕЛИЯТ СЪЛЮШЪН!
            Console.WriteLine(wordCount);      // ЗА ДА СИ ИЗПОЛЗВАМЕ ЕКСТ. МЕТОДА ТРЯБВА ДА СА НИ КЛАСОВЕТЕ В ЕДИН И СЪЩ НЕЙМСПЕЙС, ЗАЕДНО С ЕКСТ.МЕТОДА. ЗАТОВА
                                               // АКО ИСКАМЕ ДА СИ ГИ ПОЛЗВАМЕ И НА ДР. МЕСТА(КЛАСОВЕ, СЪЛЮШЪНИ) ЕКСТ.МЕТОДИТЕ ПРОСТО ПИШЕМ ОТГОРЕ В ЮЗИНГИТЕ using... И НЕЙМСПЕЙСА В КОЙТО СЕ НАМИРА ЕКСТ.МЕТОДА
                                               // НАПРИМЕР using ExtensionMethods; КЪДЕТО СЕ НАМИРА ЕКСТ.МЕТОДА(НЕЙМСПЕЙСЪТ МУ) И ВЕЧЕ ВС Е ОК

            var antotherText = "this is just an example";
            Console.WriteLine(antotherText.CountWords()); // тук директно си извикваме екст.метода в райтлайна , да не пишем, като горе в друга променлива и тн ...

            #endregion

            #region Anonymous Types

            var studen = new { FirstName = "Pesho", LastName = "Goshev" };   // създава се ето така

            Console.WriteLine(studen.FirstName);  // и можем да достъпваме пропъртитата (стойностите) по обичайният начин
            Console.WriteLine(studen.LastName);
            #endregion

            #region Delegates

            // Instantiate the delegate
            SimpleDelegate d = new SimpleDelegate(TestMethod);

            //// The above can be written in a shorter way
            d = TestMethod;

            // Invocation of the method, pointed by delegate
            d("test");

            #endregion

            #region Predefined Delegates

            //    // Action<int> logNumber = Console.WriteLine;
            //    Action<int> logNumber = (number) => Console.WriteLine(number);
            //    logNumber(5);

            //    Action<string, int> logNameAge = (name, age) =>
            //    {
            //        Console.WriteLine("Name: " + name);
            //        Console.WriteLine("Age: " + age);
            //    };
            //    logNameAge("Pesho", 5);

            //    // Func<string> magic = () => "Magic";
            //    Func<string> magic = () =>
            //    {
            //        return "Magic";
            //    };
            //    Console.WriteLine(magic());

            //    Func<string, int> parser = int.Parse;
            //    int someNumber = parser("50");
            //    Console.WriteLine(someNumber);

            //    string[] someStrings = { "Pesho", "Ivaylo", "Gosho", "Niki" };
            //    someStrings.Each(Console.WriteLine);
            //    someStrings.Each(str =>
            //    {
            //        Console.Write(str + " ");
            //    });
            //    Console.WriteLine();
            //    //// Array.ForEach(someStrings, Console.WriteLine);
            //}

            //public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
            //{
            //    foreach (var item in collection)
            //    {
            //        action(item);
            //    }
            //}

            #endregion

            #region Events



            #endregion

            #region Lambda Expressions

            var list = new List<string> { "2312", "22", "23233423", "34234234234322" };
            var sortedList = list.OrderBy(x => x.Length).ToList(); // сортира на базата на този ламбда израз
                                                                   // ето така взима ни всеки един от елементите и го подрежда по дължина
            Console.WriteLine(string.Join(", ", sortedList));
            Console.WriteLine();

            // друг израз намира всички четни числа
            var numbersList = new List<int>() { 1, 2, 3, 4, 23, 35345, 45455, 3232, 26, 554, 13 };
            var evenNumbers = numbersList.FindAll(x => (x % 2) == 0); // FindAll много полезен метод на листа...
                                                                      //(x => (x % 2) == 0) и всякакви други подобни проверки, логики,алгоритми, валидации са възможни!!!
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine();
            // пример който намира по числата по големи от 666 примерно
            var biggerNumbers = numbersList.Where(n => n > 666);
            Console.WriteLine(string.Join(", ", biggerNumbers));
            Console.WriteLine();

            // продължение на горния пример премахва всички числа по големи от 30
            numbersList.RemoveAll(x => x > 30);    // RemoveAll много полезен метод на листа...
                                                   //(x => x > 30)и всякакви други подобни проверки, логики,алгоритми, валидации са възможни!!!
            Console.WriteLine(string.Join(", ", numbersList));
            Console.WriteLine();

            // още пример с животни, сортира ги по възраст

            var pets = new Pet[]
                           {
                           new Pet { Name = "Sharo", Age = 8 },
                           new Pet { Name = "Rex", Age = 4 },
                           new Pet { Name = "Strela", Age = 1 },
                           new Pet { Name = "Odin", Age = 5 }
                           };
            var sortedPets = pets.OrderBy(pet => pet.Age);
            foreach (Pet pet in sortedPets)
            {
                Console.WriteLine("{0} -> {1}", pet.Name, pet.Age);
            }

            Console.WriteLine();

            // още 1 пример с градове, взима ни само градовете със S и след това си ги принтим с string.Join
            var towns = new List<string>() { "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra", "Sevastopol", "Sydney" };
            List<string> townsWithS = towns.FindAll((town) => town.StartsWith("S"));

            Console.WriteLine(string.Join(", ", townsWithS));
            #endregion

            #region LINQ And Queries
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var querySmallNums =
                from num in numbers   // взима числата от тази колекция едно по едно
                where num < 5 && num != 3 // направи where заявка така че числото да по-малко от 5 в случая и различно от 3, може всякаква логика да има(тука връща bool)
                select num; //+100 примерно      // и ми селектирай числото може да добавим или извадим към тая стойнотс, може да я обработим ако искаме

            foreach (var num in querySmallNums)
            {
                Console.Write(num.ToString() + " ");  // и ги принтира
            }
            // The result is 4 1 2 0

            // Друг пример:
            string[] fruits = { "cherry", "apple", "blueberry", "banana" };

            // Sort in ascending sort
            var fruitsAscending =
                from fruit in fruits
                orderby fruit
                select fruit;

            foreach (string fruit in fruitsAscending)
            {
                Console.WriteLine(fruit);
            }

            // Още 1 пример:
            string[] games = {"Morrowind", "BioShock", "Half Life",
  "The Darkness", "Daxter", "System Shock 2"};

            // Build a query expression using extension methods
            // granted to the Array via the Enumerable type

            var subset = games.Where(game => game.Length > 6).OrderBy(game => game).Select(game => game);

            foreach (var game in subset)
                Console.WriteLine(game);

            // Още 1 пример:
            string textt = "Historically, the world of data ...";
            // …
            string searchTerm = "data";
            string[] source = textt.Split(
               new char[] { '.', '?', '!', ' ', ';', ':', ',' },
               StringSplitOptions.RemoveEmptyEntries);

            // Use ToLower() to match both "data" and "Data"
            var matchQuery =
               from word in source
               where word.ToLower() == searchTerm.ToLower()
               select word;
            int worddCount = matchQuery.Count();

            #endregion

            #region LINQ-Extenstion-Methods
            // пример
            var someText = "Hi, i am  C Sharp c SHArp c sharp, how the hell Are you?";
            var wordToSearch = "sharp";

            var result = someText.Split(' ', ',').Where(w => w.ToLower() == wordToSearch.ToLower()).Count();
            Console.WriteLine(result); // 3
            // още 1 със същият стринг понеже и той е колекция от чарове и да видим как бачка
            var countA = someText.Where(s => s == 'a' || s == 'A').Count();
            Console.WriteLine("The number of A in the text is: {0}", countA);
            Console.WriteLine();

            // още един пример с List и клас Book
            //         List<Book> books = new List<Book>() {
            //           new Book { Title="LINQ in Action" },
            //           new Book { Title="LINQ for Fun" },
            //           new Book { Title="Extreme LINQ" } };
            //           var titles = books
            //            .Where(book => book.Title.Contains("Action"))
            //            .Select(book => book.Title);


            // друг пример доста голям
            LinqKeywordsExamples();
            LinqExtensionMethodsExamples();

            #endregion

            #region Dynamic

            dynamic number = 5;
            dynamic anotherNumber = 10; // ТАКА Е ОК с числа няма проблеми 

            Console.WriteLine(number + anotherNumber);
            #endregion
        }
        #region Delegates 
        public static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter: {0}.", param);
        }
        #endregion

        #region LINQ And Queries
        private static void LinqKeywordsExamples()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var querySmallNums =
                from num in numbers
                where num < 5
                select num;

            foreach (var num in querySmallNums)
            {
                Console.Write(num.ToString() + " ");
            }

            // The result is 4 1 3 2 0
            Console.WriteLine();
            Console.WriteLine();

            string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

            var townPairs =
              from t1 in towns
              from t2 in towns
              select new { T1 = t1, T2 = t2 };

            foreach (var townPair in townPairs)
            {
                Console.WriteLine(townPair);
            }

            Console.WriteLine();

            string[] fruits = { "cherry", "apple", "blueberry", "banana" };

            // Sort in ascending sort
            var fruitsAscending =
                from fruit in fruits
                orderby fruit
                select fruit;

            foreach (string fruit in fruitsAscending)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
        }

        private static void LinqExtensionMethodsExamples()
        {
            var studentsRepository = new StudentsRepository();
            var students = studentsRepository.GetAllStudents();

            // where
            var someStudents = students.Where(st => st.Name == "Ivan" || st.Name == "Pesho");
            PrintCollection(someStudents);

            // first
            Student first = students.FirstOrDefault(st => st.Courses.Count == 4); // First
            Console.WriteLine(first);

            // select
            var projectedItems = students.Select(
                st => new Student { Name = st.Id.ToString(), Courses = new List<Course>() });
            PrintCollection(projectedItems);

            // select to annonymous
            var annStudents = students.Select(st => new { Id = st.Id, Courses = st.Courses.Count });
            PrintCollection(annStudents);

            // order by
            var ordered = students.OrderBy(st => st.Courses.Count).ThenBy(st => st.Name);
            PrintCollection(ordered);

            // any
            bool checkAny = students.Any(st => st.Name.StartsWith("I"));
            Console.WriteLine(checkAny);

            // all
            bool checkAll = students.All(st => st.Name != string.Empty);
            Console.WriteLine(checkAll);
            checkAll = students.All(st => st.Id > 2);
            Console.WriteLine(checkAll);

            // ToList and ToArray
            Student[] arrayOfStudents = students.ToArray();
            PrintCollection(arrayOfStudents);
            List<Student> listOfStudents = arrayOfStudents.ToList();
            PrintCollection(listOfStudents);

            // reading string of numbers separated by space
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            PrintCollection(numbers);

            // reverse
            students.Reverse();
            PrintCollection(students);

            // average
            double averageCourses = students.Average(st => st.Courses.Count);
            Console.WriteLine(averageCourses);

            // max
            int max = students.Max(st => st.Courses.Count);
            Console.WriteLine(max);

            // min
            int min = students.Min(st => st.Courses.Count);
            Console.WriteLine(min);

            // count
            int count = students.Count(st => st.Name.Length > 4);
            Console.WriteLine(count);

            // sum
            int sum = students.Sum(st => st.Courses.Count);
            Console.WriteLine(sum);

            // extension methods
            var someCollection =
                students.Where(st => st.Id > 1)
                    .OrderBy(st => st.Name)
                    .ThenBy(st => st.Courses.Count)
                    .Select(st => new { Name = st.Name, Courses = st.Courses.Count })
                    .ToArray();

            PrintCollection(someCollection);

            // nesting
            var someOtherStudents = students.Where(st => st.Courses.Any(c => c.Name == "OOP")).OrderBy(st => st.Name);
            PrintCollection(someOtherStudents);
        }

        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion
}

