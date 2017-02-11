using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        char currentOperator = '+';
        char currentBracketOperator = '+';
        decimal result = 0;
        decimal currentBracketResult = 0;
        bool inBracket = false;
        foreach (char symbol in expression)
        {
            // Проверява дали има скоби
            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }
            if (symbol == ')')
            {
                inBracket = false;
                currentBracketOperator = '+';
                switch (currentOperator)
                {
                    case '+': result += currentBracketResult; break;
                    case '-': result -= currentBracketResult; break;
                    case '%': result %= currentBracketResult; break;
                    case '*': result *= currentBracketResult; break;
                }

                currentBracketResult = 0; // 1. БЕШЕ ПРЕДИ SWITCH-A
            }
            // Проверява какъв е символа
            switch (symbol)
            {
                case '+':
                case '-':
                case '%':
                case '*':
                    {    // 2. НЕ БЕШЕ ПОСТАВЕНО КОРЕКТНО СЛЕД CASE-A
                        if (inBracket)
                        {
                            currentBracketOperator = symbol;
                        }
                        else
                        {
                            currentOperator = symbol;
                        }
                    }
                    break;
            }
            //Проверява дали е число
            if (symbol >= '0' && symbol <= '9')
            {
                int currentNumber = symbol - '0';
                //Ако има скоба, праща числото вътре. Ако няма - в крайния резултат
                if (inBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+': currentBracketResult += currentNumber; break;
                        case '-': currentBracketResult -= currentNumber; break;
                        case '%': currentBracketResult %= currentNumber; break;
                        case '*': currentBracketResult *= currentNumber; break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber; break;
                        case '-': result -= currentNumber; break;
                        case '%': result %= currentNumber; break;
                        case '*': result *= currentNumber; break;
                    }
                }
            }
        }

        Console.WriteLine("{0:F3}", result); //3 ИЗВЪН ЦИКЪЛА
    }
}