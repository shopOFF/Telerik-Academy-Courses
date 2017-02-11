using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> alphabet = new List<string>() { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

        // algoritam za konvertirane ot vsqkakva broina sistema v deseti4na, za primera se polzva 15-ti4na!!!
        string digitIn15 = "";
        BigInteger decimalValue = 0;                  // BigInteger za po sigurno
        BigInteger decimalRepresentation = 0;         // BigInteger za po sigurno
        for (int i = 0; i < input.Length; i += 4)     // poneje ni cifrite sa ni grupirani po 4 
        {
            digitIn15 = input.Substring(i, 4);  // taka si namirame koq to4no e dumi4kata ot masiva na koq poziciq e moje da polzvame i switch ili ifove ....
            decimalValue = alphabet.IndexOf(digitIn15);   // za da si namerim stoinosta im v aZBUKATA , MOJE DA SE POLZVAT SWITCHOVE ili ifove nqma zna4enie no tuk za po lesno moje i taka indexa v masiva ni pokazva i stoinosta na 4isloto v 15-i4na
            // ot tuk nanataka si povtarqme standarnite preobrazuvanq, kato po dolo
            decimalRepresentation *= 15;
            decimalRepresentation += decimalValue;
        }
        Console.WriteLine(decimalRepresentation); // tova e krainiqt rezultat
    }
}


//// algoritam za konvertirane ot vsqkakva broina sistema v deseti4na, za primera se polzva 16-ti4na, za drugi se smenqt parametrite i ba4ka!!!
//var hex = "FAB1";

//int decimalRepresentation = 0;
//for (int i = 0; i < hex.Length; i++)
//{
//    decimalRepresentation *= 16;  // umnojavame po broinata sistema s koqto rabotim v slu4aq v 16-ti4na
//    if (hex[i] >= '0' && hex[i] <= '9')     // tuk 6te ni dade saio6tveniqt simvol 1=1, 0=0, za 4islata ot 0 do 9
//    {
//        decimalRepresentation += hex[i] - '0';   // tuk 6te ni go obarne v cifra 
//    }
//    else
//    {                                        // tuk 6te ni go obarne v cifra     no 4islata ot 10 nagore, kato A=10, B=11 i tn....  
//        decimalRepresentation += hex[i] + 10 - 'A';   //  mnogo dobro re6enie
//    }
//}
//Console.WriteLine(decimalRepresentation); // tova e krainiqt rezultat