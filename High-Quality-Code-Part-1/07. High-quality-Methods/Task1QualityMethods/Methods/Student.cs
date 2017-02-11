namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime petersBirthDate = this.DateOfBirth;
            DateTime stellasBirthDate = otherStudent.DateOfBirth;

            bool isPeterOlderThanStella = petersBirthDate < stellasBirthDate;

            return isPeterOlderThanStella;
        }
    }
}
