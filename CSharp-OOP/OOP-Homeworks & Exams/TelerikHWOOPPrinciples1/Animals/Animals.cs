namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender gender;


        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty !!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age must be a positive number !!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} - Age: {1} - Gender: {2}", this.Name, this.Age, this.Gender);
        }


        public static double AnimalAverageAge(IEnumerable<Animal> animalList)
        {
            var result = animalList.Average(x => x.Age);
            return result;
        }
    }
}