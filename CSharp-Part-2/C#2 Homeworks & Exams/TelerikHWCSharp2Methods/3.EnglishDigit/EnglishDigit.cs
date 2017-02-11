using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnglishDigit
{
    static string ExtractLastDigit(int digit)    // static string za6toto 6te ni varne string tozi metod vapreki 4e mu podavame parametar int !!!!
    {
        int lastDigit = digit % 10; // za da namerim psolednata cifra

        switch (lastDigit)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "zero";
        }
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ExtractLastDigit(number));
    }
}

// re6enie sas string tova e mojebi po dobroto re6enie (po malko pamet i po barzo raboti)
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class EnglishDigit
//{
//    static string ExtractLastDigit(string digit)
//    {
//        char lastDigit = digit[digit.Length - 1]; // ili digit.Last() - edni isa6to pravi

//        switch (lastDigit)
//        {
//            case '1': return "one";
//            case '2': return "two";
//            case '3': return "three";
//            case '4': return "four";
//            case '5': return "five";
//            case '6': return "six";
//            case '7': return "seven";
//            case '8': return "eight";
//            case '9': return "nine";
//            default: return "zero";
//        }
//    }
//    static void Main()
//    {
//        string number = Console.ReadLine();
//        Console.WriteLine(ExtractLastDigit(number));
//    }
//}