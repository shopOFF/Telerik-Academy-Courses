using System;

class Solution
{
    static string GetCypherLength(string all)
    {
        var result = "";
        var i = all.Length - 1;

        while(char.IsDigit(all[i]))
        {
            result = all[i] + result;
            i--;
        }

        return result;
    }

    static string WithoutLengthOfCypher(string all, string lengthOfCypher)
    {
        var withoutLength = all.Length - lengthOfCypher.Length;

        return all.Substring(0, withoutLength);
    }

    static string Decode(string encoded)
    {
        var result = "";

        for(var i = 0; i < encoded.Length; i++)
        {
            var currentRepeat = "";

            while(char.IsDigit(encoded[i]))
            {
                currentRepeat += encoded[i];
                i++;
            }

            if(currentRepeat == "")
            {
                currentRepeat = "1";
            }

            var amount = int.Parse(currentRepeat);

            result += new String(encoded[i], amount);
        }

        return result;
    }

    static string GetCypher(string msgAndCypher, int cypherLength)
    {
        return msgAndCypher.Substring(msgAndCypher.Length - cypherLength);
    }

    static string GetEncryptedPart(string msgAndCypher, int cypherLength)
    {
        return msgAndCypher.Substring(0, msgAndCypher.Length - cypherLength);
    }

    static int CodeOf(char symbol)
    {
        return symbol - 'A';
    }

    static char CharOf(int code)
    {
        return (char)(code + 'A');
    }

    static string Encrypt(string message, string cypher)
    {
        var result = message.ToCharArray();
        var length = Math.Max(message.Length, cypher.Length);

        for(var i = 0; i < length; i++)
        {
            var newCode = CodeOf(result[i % result.Length]) ^ CodeOf(cypher[i % cypher.Length]);
            var newChar = CharOf(newCode);

            result[i % result.Length] = newChar;
        }

        return new String(result);
    }

    static void Solve()
    {
        var all = Console.ReadLine();

        var lengthOfCypher = GetCypherLength(all);
        var withoutLength = WithoutLengthOfCypher(all, lengthOfCypher);

        var decoded = Decode(withoutLength);
        var cypher = GetCypher(decoded, int.Parse(lengthOfCypher));
        var encrypted = GetEncryptedPart(decoded, int.Parse(lengthOfCypher));

        var decrypted = Encrypt(encrypted, cypher);

        System.Console.WriteLine(decrypted);
    }

    static void Main()
    {
        Solve();
    }
}