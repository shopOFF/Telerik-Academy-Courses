using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculationProblem
{
    private static long Pow(int a, int b)
    {
        long result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }
    static long ConvertToDecimal(string[] nums)
    {
        string mhm = "";
        List<int> alphabeticalOrder = new List<int>();
        long decimalResult = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            mhm = nums[i];
            for (int j = 0; j < mhm.Length; j++)
            {
                alphabeticalOrder.Add(mhm[j] - 'a');
            }
            for (int k = 0; k < alphabeticalOrder.Count; k++)
            {
                decimalResult += alphabeticalOrder[k] * (Pow(23, alphabeticalOrder.Count - (k + 1)));
            }
            alphabeticalOrder.Clear();
        }
        return decimalResult;
    }
    static string ConvertTo23Based(long decResult)  // taka namirame ot tazi baza 23
    {
        long reminder = 0;
        long numeralBase = 23;
        string result = string.Empty;  // taka se pravi prazen string
        while (decResult > 0)
        {
            reminder = decResult % numeralBase;
            result += Convert.ToChar('a' + reminder); // za da si namerim koq ni e bukvata spored uslovieto, no ni gi pribavq na obratno, zatova otdolo gi obra6tame po pravilniqt na4in !!!
            decResult /= numeralBase;                   // i da si gi obarnem ot 4isla v bukvi pi6em Convert.ToChar() ili samo (char) i kastvame kam char
        }
        char[] resultArray = result.ToArray();  // taka si obra6tame 
        Array.Reverse(resultArray);
        return new string(resultArray);    // i taka stava s new string vmesto da gi convertirame kam druga promenliva ot string...
    }
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ').ToArray();

        long decResult = ConvertToDecimal(nums);
        string result23Based = ConvertTo23Based(decResult);
        Console.WriteLine("{0} = {1}", result23Based, decResult);
    }
}