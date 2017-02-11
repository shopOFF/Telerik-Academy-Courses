using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexadecimal
{
    static string ConvertBinaryToHex(string n)
    {
        string binToHex = Convert.ToInt64(n, 2).ToString("X");
        return binToHex;
    }
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertBinaryToHex(n));
    }
}

// drug na4in 
 //static void Main()
 //       {
 //           // input BinaryNumber
 //           string BinNumber = Console.ReadLine();

 //           // variables
 //           string HexNumber = "";

 //           string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

 //           int fromBase = 2;

 //           string curBinSection = "";
 //           int curHexIndex = 0;

 //           while (BinNumber.Length > 0)
 //           {
 //               // Last four digits OR all of it if length less than 4
 //               if (BinNumber.Length >= 4)
 //               {
 //                   curBinSection = BinNumber.Substring(BinNumber.Length - 4, 4);
 //                   BinNumber = BinNumber.Remove(BinNumber.Length - 4, 4);
 //               }
 //               else
 //               {
 //                   curBinSection = BinNumber;
 //                   BinNumber = "";
 //               }

 //               // reset
 //               curHexIndex = 0;

 //               for (int i = 0; i < curBinSection.Length; i++)
 //               {
 //                   curHexIndex += (int)Math.Pow(fromBase, i)
 //                               * int.Parse(curBinSection[curBinSection.Length - 1 - i].ToString());
 //               }

 //               HexNumber = HexKey[curHexIndex] + HexNumber;
 //           }

 //           Console.WriteLine(HexNumber);
 //       }