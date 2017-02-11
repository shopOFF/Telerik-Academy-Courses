namespace SchoolClasses
{
    using System;
    public class Person
    {
        private string firstName;
        private string lastName;


        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid First Name!");
                }
                else
                {
                    this.firstName = value;
                }

            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid Last Name!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
