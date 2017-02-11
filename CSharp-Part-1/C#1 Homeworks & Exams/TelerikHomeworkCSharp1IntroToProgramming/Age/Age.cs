using System;

class Age
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        int age = 0;
        int ageAfter10Years = 0;

        if (birthday.Month > today.Month)
        {
            age = (today.Year - birthday.Year) - 1;
            ageAfter10Years = age + 10;
        }
        else
        {
            age = today.Year - birthday.Year;
            ageAfter10Years = age + 10;
        }
        Console.WriteLine(age);
        Console.WriteLine(ageAfter10Years);
    }
}
// Second Solution:

        //DateTime today = DateTime.Now;
        //DateTime birthday = DateTime.Parse(Console.ReadLine());

        //if (birthday.Month > today.Month)
        //{
        //    Console.WriteLine((today.Year - birthday.Year) - 1);
        //    Console.WriteLine((today.Year - birthday.Year) + 9);
        //}
        //else
        //{
        //    Console.WriteLine(today.Year - birthday.Year);
        //    Console.WriteLine((today.Year - birthday.Year) + 10);
        //}