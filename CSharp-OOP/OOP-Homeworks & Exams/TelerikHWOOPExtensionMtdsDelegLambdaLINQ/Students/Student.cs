namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int facultyNumber;
        private string phoneNumber;
        private int age;
        private string email;

        //TODO:.................
        public Student(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FacultyNumber = 0;
            this.PhoneNUmber = string.Empty;
            this.Age = 0;
            this.email = string.Empty;
        }
       

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Invalid First Name!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Invalid Last Name!");
                }
                lastName = value;
            }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value < 3)
                {
                    throw new ArgumentException("Invalid Faculty Number!");
                }
                facultyNumber = value;
            }
        }

        public string PhoneNUmber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length < 9)
                {
                    throw new ArgumentException("Invalid Phone Number!");
                }
                phoneNumber = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 15)
                {
                    throw new ArgumentException("Invalid Age!");
                }
                age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Invalid Email!");
                }
                email = value;
            }
        }



        public override string ToString()
        {

            return base.ToString();
        }
    }

}
