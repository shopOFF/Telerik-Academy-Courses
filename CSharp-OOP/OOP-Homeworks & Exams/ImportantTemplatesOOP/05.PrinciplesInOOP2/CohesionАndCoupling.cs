namespace _05.PrinciplesInOOP2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CohesionАndCoupling
    {
        // КОХЕЗИЯ: КОЛКО ЕДИН КЛАС ВЪРШИ ЕДНА КОНКРЕТНА ДЕЙНОСТ! ВСЕКИ МЕТОД ДА ПРАВИ ВЪЗМОЖНО НАЙ-МАЛКО, ВСЕКИ КЛАС ДА СИ Е СТРОГО ТИПИЗИРАН И ТН..
        // НАПРИМЕР-ИМАТЕ СИ КЛАС КУЧЕ И В ТОЗИ КЛАС СИ ИМАТЕ САМО НЕЩА ЗА КУЧЕТО И ТОГАВА КАЗВАТЕ,ЧЕ ИМАТЕ СИЛНА КОХЕЗИЯ(ДОБРЕ НАПИСАН)!
        //        Cohesion
        //Cohesion describes
        //How closely the routines in a class or the code in a routine support a central purpose
        //Cohesion must be strong
        //Well-defined abstractions keep cohesion strong
        //Classes must contain strongly related functionality and aim for single purpose
        //Cohesion is a powerful tool for managing complexity

        // ДОБРА ПРАКТИКА:
        //СИЛНА КОХЕЗИЯ
        //        Strong Cohesion
        //Strong cohesion(good cohesion) example
        //Class Math that has methods:
        //Sin(), Cos(), Asin()
        //Sqrt(), Pow(), Exp()
        //Math.PI, Math.E
        // double sideA = 40, sideB = 69;
        //        double angleAB = Math.PI / 3;

        //        double sideC =
        //            Math.Pow(sideA, 2) + Math.Pow(sideB, 2)
        //            - 2 * sideA * sideB * Math.Cos(angleAB);

        //        double sidesSqrtSum = Math.Sqrt(sideA) + Math.Sqrt(sideB)
        //         + Math.Sqrt(sideC);

        // ЛОША ПРАКТИКА:
        // СЛАБА КОХЕЗИЯ
        //        Weak Cohesion
        //Weak cohesion(bad cohesion) example
        //Class Magic that has these methods:
        // public void PrintDocument(Document d);
        //        public void SendEmail(
        //        string recipient, string subject, string text);
        //        public void CalculateDistanceBetweenPoints(
        //        int x1, int y1, int x2, int y2)
        //Another example:
        // MagicClass.MakePizza("Fat Pepperoni");
        //MagicClass.WithdrawMoney("999e6");
        //MagicClass.OpenDBConnection();



        // КЪПЛИНГ: ОБЯСНЯВА, КОЛКО СА ВЪРЗАНИ ДВА КЛАСА ИЛИ СБИРЩИНА ОТ КЛАСОВЕ, КОЛКО СА ВЪРЗАНИ ЕДИН КЪМ ДРУГ И 
        // КОЛКО ТЕ НЕ МОГЪТ ДА РАБОТЯТ ЕДИН БЕЗ ДРУГ! ТОЕСТ ВИЕ ТРЯБВА ДА ДЪРЖИТЕ ВЪЗМОЖНО НАЙ-МАЛКО ТАКЪВ КЪПЛИНГ!
        // ТОЕСТ НЕ МОЖЕ ЕДИН КЛАС ДА ДЕПЕНДВА МНОГО СИЛНО НА ДРУГ КЛАС! ТОВА Е МН ГРЕШНО, ЗАШОТО НЕ ВИ ПОЗВОЛЯВА ДА ЕКСТЕНДВАТЕ И ТН...
        // 
        //        Coupling
        //Coupling describes how tightly a class or routine is related to other classes or routines
        //Coupling must be kept loose
        //Modules must depend little on each other
        //Or be entirely independent(loosely coupled)
        //All classes / routines must have small, direct, visible, and flexible relationships to other classes / routines
        //One module must be easily used by other modules


        //        Loose and Tight Coupling
        //Loose Coupling:
        //Easily replace old HDD
        //Easily place this HDD
        //to another motherboard

        //Tight Coupling:
        //Where is the video adapter?
        //Can you change the video controller?
       
        //ДОБРА ПРАКТИКА:
        //    Loose Coupling – Example
        //        class Report
        //        {
        //            public bool LoadFromFile(string fileName) {…}
        //            public bool SaveToFile(string fileName) {…}
        //        }
        //        class Printer
        //        {
        //            public static int Print(Report report) {…}
        //        }
        //        class Program
        //        {
        //            static void Main()
        //            {
        //                Report myReport = new Report();
        //                myReport.LoadFromFile("C:\\DailyReport.rep");
        //                Printer.Print(myReport);
        //            }
        //        }

        // МНОГО ЛОША ПРАКТИКА
        //    Tight Coupling – Example
        //        class MathParams
        //        {
        //            public static double operand;
        //            public static double result;
        //        }
        //        class MathUtil
        //        {
        //            public static void Sqrt()
        //            {
        //                MathParams.result = CalcSqrt(MathParams.operand);
        //            }
        //        }
        //        class MainClass
        //        {
        //            static void Main()
        //            {
        //                MathParams.operand = 64;
        //                MathUtil.Sqrt();
        //                Console.WriteLine(MathParams.result);

        //            }
        //        }

        // МНОГО ЛОША ПРАКТИКА:
        //        Spaghetti Code
        //  Combination of bad cohesion and tight coupling:
        //        class Report
        //        {
        //            public void Print() {…}
        //            public void InitPrinter() {…}
        //            public void LoadPrinterDriver(string fileName) {…}
        //            public bool SaveReport(string fileName) {…}
        //            public void SetPrinter(string printer) {…}
        //        }
        //        class Printer
        //        {
        //            public void SetFileName() {…}
        //            public static bool LoadReport() {…}
        //            public static bool CheckReport() {…}
        //        }

    }
}
