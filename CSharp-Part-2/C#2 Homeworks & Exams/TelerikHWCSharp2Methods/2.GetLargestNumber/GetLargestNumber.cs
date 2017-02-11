using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetLargestNumber
{
    static int GetMax(int firstNum, int secondNum)   // variant s vra6tane na stoinost 
    {
        if (firstNum > secondNum)
        {
            return firstNum;     // ako parvoto e po golqmo 6te ni varne nego metoda ni 6te e s tazi stoinost(GetMax-6te ima negovata stoinost)
                                 // return ni vra6ta tazi stoinost i taka samiqt metod ve4e e stazi stoinost
        }
        else
        {
            return secondNum;   // ako vtoroto e po golqmo 6te ni varne nego (GetMax-6te ima negovata stoinost)
        }
    }
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] intInput = Array.ConvertAll(input, int.Parse);
        int biggestNum = int.MinValue;  // moje i bez tazi propemnliva direktno da si izprintim GetMax(), no za da se vijda 4e s GetMax(intInput[0], intInput[2])
                                        //parvo vavejdame parametrite koito iskame i vednaga sled tova s return - ni se vra6ta jelanata stoinost, koqto si pravim kakvoto si sikame!!!!!!!!!!
        if (intInput[0] > intInput[1])
        {
            biggestNum = GetMax(intInput[0], intInput[2]); // vavejdame parametrite koito iskame i vednaga sled tova s return - ni se vra6ta jelanata stoinost(ili stoinosti), koqto si pravim kakvoto si sikame!!!!!!!!!!
            Console.WriteLine(biggestNum); // printirame si ve4e obrabotenata stoinost(moje i direktno GetMax(intInput[0], intInput[2]) da si izprintim, ako iskame)
        }
        else
        {
            biggestNum = GetMax(intInput[1], intInput[2]);  // vavejdame parametrite koito iskame i vednaga sled tova s return - ni se vra6ta jelanata stoinost(ili stoinosti), koqto si pravim kakvoto si sikame!!!!!!!!!!
            Console.WriteLine(biggestNum);   // printirame si ve4e obrabotenata stoinost
        }
    }
}
// vtori variant v koito metoda ne ni vra6ta stoinost a prosto si izvar6va deistvieto i printi 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class GetLargestNumber
//{
//    static void GetMax(int firstNum, int secondNum)
//    {
//        if (firstNum > secondNum)
//        {
//            Console.WriteLine(firstNum);
//        }
//        else
//        {
//            Console.WriteLine(secondNum);
//        }
//    }
//    static void Main()
//    {
//        string[] input = Console.ReadLine().Split(' ');
//        int[] intInput = Array.ConvertAll(input, int.Parse);

//        if (intInput[0] > intInput[1])
//        {
//            GetMax(intInput[0], intInput[2]);
//        }
//        else
//        {
//            GetMax(intInput[1], intInput[2]);
//        }
//    }
//}