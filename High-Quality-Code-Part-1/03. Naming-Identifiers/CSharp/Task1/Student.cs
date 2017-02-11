using System;

public class Student
{
    private const int FIRST_NAME_MAX_LENGTH = 16;
    private const int FIRST_NAME_MIN_LENGTH = 2;

    public class StudentFirstName
    {
        public void CheckIfFirstNameIsValid(string firstName)
        {
            if (FIRST_NAME_MAX_LENGTH > firstName.Length && 
                FIRST_NAME_MIN_LENGTH < firstName.Length)
            {
                Console.WriteLine("{0} is a valid first name!", firstName);
            }
            else
            {
                Console.WriteLine("{0} is NOT a valid first name!", firstName);
            }
        }
    }

    public static void Main()
    {
        var student = new StudentFirstName();
        var validStudentFirstName = "Nikodim";
        var invalidStudentFirstName = "Ni";

        student.CheckIfFirstNameIsValid(validStudentFirstName);
        student.CheckIfFirstNameIsValid(invalidStudentFirstName);
    }
}