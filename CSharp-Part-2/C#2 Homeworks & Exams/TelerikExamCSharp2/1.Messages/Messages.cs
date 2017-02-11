using System;
using System.Collections.Generic;
using System.Numerics;

public class Messages
{
    public static void Main()
    {
        string firstNum = Console.ReadLine();
        char operation = char.Parse(Console.ReadLine());
        string secondNum = Console.ReadLine();
        BigInteger resultInDec = 0;
        string resultInEcpryptionSystem = string.Empty;
        List<string> alphabet = new List<string>() { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        string firstDigitIn10 = "";
        BigInteger firstNumDecimalValue = 0;                  // BigInteger za po sigurno
        BigInteger firstNumDecRepresent = 0;         // BigInteger za po sigurno
        for (int i = 0; i < firstNum.Length; i += 3)     // poneje ni cifrite sa ni grupirani po 4 
        {
            firstDigitIn10 = firstNum.Substring(i, 3);  // taka si namirame koq to4no e dumi4kata ot masiva na koq poziciq e moje da polzvame i switch ili ifove ....
            firstNumDecimalValue = alphabet.IndexOf(firstDigitIn10);   // za da si namerim stoinosta im v aZBUKATA , MOJE DA SE POLZVAT SWITCHOVE ili ifove nqma zna4enie no tuk za po lesno moje i taka indexa v masiva ni pokazva i stoinosta na 4isloto v 15-i4na
            // ot tuk nanataka si povtarqme standarnite preobrazuvanq, kato po dolo
            firstNumDecRepresent *= 10;
            firstNumDecRepresent += firstNumDecimalValue;
        }
        string secondDigitIn10 = "";
        BigInteger secondNumDecimalValue = 0;                  // BigInteger za po sigurno
        BigInteger seconddNumDecRepresent = 0;         // BigInteger za po sigurno

        for (int i = 0; i < secondNum.Length; i += 3)     // poneje ni cifrite sa ni grupirani po 4 
        {
            secondDigitIn10 = secondNum.Substring(i, 3);  // taka si namirame koq to4no e dumi4kata ot masiva na koq poziciq e moje da polzvame i switch ili ifove ....
            secondNumDecimalValue = alphabet.IndexOf(secondDigitIn10);   // za da si namerim stoinosta im v aZBUKATA , MOJE DA SE POLZVAT SWITCHOVE ili ifove nqma zna4enie no tuk za po lesno moje i taka indexa v masiva ni pokazva i stoinosta na 4isloto v 15-i4na
            // ot tuk nanataka si povtarqme standarnite preobrazuvanq, kato po dolo
            seconddNumDecRepresent *= 10;
            seconddNumDecRepresent += secondNumDecimalValue;
        }

        if (operation == '-')
        {
            resultInDec = firstNumDecRepresent - seconddNumDecRepresent;
        }
        else
        {
            resultInDec = firstNumDecRepresent + seconddNumDecRepresent;
        }

        while (resultInDec > 0)
        {
            // remainders build the new digit right to left
            resultInEcpryptionSystem = alphabet[(int)(resultInDec % 10)] + resultInEcpryptionSystem;  // taka pi6em, za da ni dolepva bukvite v pravilen red, ina4e [parvo slaga poslednata i tn

            // divide by base
            resultInDec /= 10;
        }

        Console.WriteLine(resultInEcpryptionSystem); // tova e krainiqt rezultat
    }
}