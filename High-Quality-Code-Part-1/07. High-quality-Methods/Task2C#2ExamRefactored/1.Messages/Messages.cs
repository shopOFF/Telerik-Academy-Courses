using System;
using System.Collections.Generic;
using System.Numerics;

public class Messages
{
    private const int DECIMAL_NUMERAL_SYSTEM_BASE = 10;

    public static void Main()
    {
        string firstNumber = Console.ReadLine();
        char operation = char.Parse(Console.ReadLine());
        string secondNumber = Console.ReadLine();

        List<string> georgeTheGreatNumeralSystemDigits = new List<string>() { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        var firstNumberInDecimal = ConvertGeorgeTheGreatNumeralSystemToDecimal(firstNumber, georgeTheGreatNumeralSystemDigits);
        var secondNumberInDecimal = ConvertGeorgeTheGreatNumeralSystemToDecimal(secondNumber, georgeTheGreatNumeralSystemDigits);
        var resultInDecimal = CalculateingTheResultOfTheOperatorationInDecimal(firstNumberInDecimal, secondNumberInDecimal, operation);

        Console.WriteLine(ConvertDecimalToGeorgeTheGreatNumeralSystem(resultInDecimal, georgeTheGreatNumeralSystemDigits));
    }

    private static BigInteger ConvertGeorgeTheGreatNumeralSystemToDecimal(string number, List<string> georgeTheGreatNumeralSystemDigits)
    {
        BigInteger numberDecimalValue = 0;
        BigInteger numberDecimalRepresent = 0;
        string digitInDecimal = string.Empty;

        for (int i = 0; i < number.Length; i += 3)
        {
            digitInDecimal = number.Substring(i, 3);
            numberDecimalValue = georgeTheGreatNumeralSystemDigits.IndexOf(digitInDecimal);

            numberDecimalRepresent *= DECIMAL_NUMERAL_SYSTEM_BASE;
            numberDecimalRepresent += numberDecimalValue;
        }

        return numberDecimalRepresent;
    }

    private static BigInteger CalculateingTheResultOfTheOperatorationInDecimal(BigInteger firstNumber, BigInteger secondNumber, char operation)
    {
        BigInteger result = 0;

        if (operation == '-')
        {
            result = firstNumber - secondNumber;
        }
        else
        {
            result = firstNumber + secondNumber;
        }

        return result;
    }

    private static string ConvertDecimalToGeorgeTheGreatNumeralSystem(BigInteger number, List<string> georgeTheGreatNumeralSystemDigits)
    {
        string resultInGeorgeTheGreatNumeralSystem = string.Empty;

        while (number > 0)
        {
            resultInGeorgeTheGreatNumeralSystem = georgeTheGreatNumeralSystemDigits[(int)(number % DECIMAL_NUMERAL_SYSTEM_BASE)] + resultInGeorgeTheGreatNumeralSystem;

            number /= DECIMAL_NUMERAL_SYSTEM_BASE;
        }

        return resultInGeorgeTheGreatNumeralSystem;
    }
}