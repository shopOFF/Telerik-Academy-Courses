using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder nums = new StringBuilder();
        StringBuilder tableCOnversion = new StringBuilder();
        string[] HexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');
        for (int i = 0; i < input.Length; i++)
        {
            nums.Append(input[i]);
            if (nums.Length == 3)
            {
                switch (nums.ToString())
                {
                    case "CHU": tableCOnversion.Append(0);
                        break;
                    case "TEL": tableCOnversion.Append(1);
                        break;
                    case "OFT": tableCOnversion.Append(2);
                        break;
                    case "IVA": tableCOnversion.Append(3);
                        break;
                    case "EMY": tableCOnversion.Append(4);
                        break;
                    case "VNB": tableCOnversion.Append(5);
                        break;
                    case "POQ": tableCOnversion.Append(6);
                        break;
                    case "ERI": tableCOnversion.Append(7);
                        break;
                    case "CAD": tableCOnversion.Append(8);
                        break;
                    case "K-A": tableCOnversion.Append(9);
                        break;
                    case "IIA": tableCOnversion.Append("A");
                        break;
                    case "YLO": tableCOnversion.Append("B");
                        break;
                    default: tableCOnversion.Append("C");
                        break;
                }
                nums.Clear();
            }
        }
        // convert to decimal
        string resultTostring = tableCOnversion.ToString();
        Console.WriteLine(AnyToDec(resultTostring, 13, HexKey));
    }
    public static string AnyToDec(string toConvert, int fromBase, string[] Key)
    {
        BigInteger Sum = 0;

        for (int curIndex = 0; curIndex < toConvert.Length; curIndex++)
        {
            // base ^ index ( right to left ) * value of the digit
            Sum += BigInteger.Pow(fromBase, curIndex)
                * Array.IndexOf(Key, toConvert[toConvert.Length - 1 - curIndex].ToString());   // tuka moje da se naloji da napravim sobsten metod za iz4islqvane na stepen vmesto Math.Pow() za6toto pri celi 4isla dava otkoloneniq(poneje izpolzva priblijeniq)!!! 
        }                                                                                     // ili vmesto tova izpolzvame BigInteger.Pow() i taka ve4e i celite 4isla se stepenuvat pravilno

        return Sum.ToString();
    }
}