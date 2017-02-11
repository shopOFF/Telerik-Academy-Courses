using System;

class TRES4Numbers
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        ulong decIn9th = 0;
        string numIn9th = "";
        string[] numSystem = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

        if (num == 0)
        {
            Console.WriteLine(numSystem[num]);
        }
        else
        {
            while (num > 0)
            {
                decIn9th = num % 9;
                numIn9th += decIn9th;
                num /= 9;
            }
            for (int i = numIn9th.Length - 1; i >= 0; i--)
            {
                Console.Write(numSystem[numIn9th[i] - '0']);
            }
        }
    }
}

