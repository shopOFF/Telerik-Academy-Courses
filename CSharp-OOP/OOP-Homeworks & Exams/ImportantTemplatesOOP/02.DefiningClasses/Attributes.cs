namespace _02.DefiningClasses
{
    using System.ComponentModel.DataAnnotations;
    public class Attributes
    {
        [Required] // ето така се слага атрибут над пропъртито
        public int Name { get; set; }

        // Атрибутите са нещо което ви позволява, вие да сетнете накаква
        // допълнителна информация, върху методи пропъртита и всякакви други неща и 
        // идеята, е че те не значат АБСУЛЮТНО НИЩО ЗА САМИЯТ КОДА(НЕ ПРОМЕНЯТ ПО НИКАКЪВ НАЧИН ТЕКУЩАТА ЛОГИКА, НЕ ПРОМЕНЯТ НИЩО)!!!
        // За да ги използваме реферираме using System.ComponentModel.DataAnnotations;  и си
        // добавяме същият неймспейс. Пишем атрибут, над самата декларация било то на клас, метод или др.
        // Идеята им е да слагат допълнителна информация в/у декларациите, която
        // евентуално някъде може да се използва!!! Тя се пази в крайният, компилиран файл и може да 
        // бъде достъпена чрез така нареченият рефлекшън(reflection)!
        // 
    }
}
// ПРИМЕР:1
//using System;
//using System.Runtime.InteropServices;

//[AttributeUsage(AttributeTargets.Struct |
//  AttributeTargets.Class | AttributeTargets.Interface,
//  AllowMultiple = true)]
//public class AuthorAttribute : System.Attribute
//{
//    public string Name { get; private set; }

//    public AuthorAttribute(string name)
//    {
//        this.Name = name;
//    }
//}

//[Author("Nikolay Kostov")]
//[Author("Doncho Minkov")]
//[Author("Ivaylo Kenov")]
//[Author("Evlogi Hristov")]
//class CustomAttributesDemo
//{
//    static void Main(string[] args)
//    {
//        Type type = typeof(CustomAttributesDemo);
//        object[] allAttributes = type.GetCustomAttributes(false);
//        foreach (AuthorAttribute authorAttribute in allAttributes)
//        {
//            Console.WriteLine("This class is written by {0}. ",
//                authorAttribute.Name);
//        }
//    }
//}

// ПРИМЕР: 2
//using System;
//using System.Runtime.InteropServices;

//class UsingAttributes
//{
//    [DllImport("user32.dll", EntryPoint = "MessageBox")]
//    public static extern int ShowMessageBox(int hWnd,
//        string text, string caption, int type);

//    static void Main()
//    {
//        ShowMessageBox(0, "Some text", "Some caption", 0);
//    }
//}