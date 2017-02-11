using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToBinary
{
    static string ConvertHexToBinary(string n)
    {
        string hexToBin = Convert.ToString(Convert.ToInt64(n, 16), 2);
        return hexToBin;
    }   
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertHexToBinary(n));
    }
}
//drug na4in 
 //static void Main()
 //       {
 //           // input
 //           string HexNumber = Console.ReadLine();

 //           // variables 
 //           string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

 //           string BinNumber = "";
 //           string tempBinNumb = "";

 //           int toBase = 2;

 //           for (int curIndex = HexNumber.Length - 1;
 //                    curIndex >= 0; curIndex--)
 //           {
 //               var curDigit = Array.IndexOf(HexKey, HexNumber[curIndex].ToString());

 //               while (curDigit > 0)
 //               {
 //                   tempBinNumb = (curDigit % toBase).ToString() + tempBinNumb;

 //                   curDigit /= toBase;
 //               }

 //               tempBinNumb = tempBinNumb.PadLeft(4, '0');

 //               BinNumber = tempBinNumb + BinNumber;

 //               tempBinNumb = "";
 //           }

 //           // Print
 //           Console.WriteLine(BinNumber.TrimStart('0'));
 //       }