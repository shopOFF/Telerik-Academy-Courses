namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines = new List<Discipline>();

        private List<string> comment = new List<string>();


        public Teacher(string firstName, string lastName, params Discipline[] disciplines)
            : base(firstName, lastName)
        {
            this.DisciplinesList.AddRange(disciplines);
        }

        public List<Discipline> DisciplinesList
        {
            get { return this.disciplines; }
            private set
            {
                if (value.Count < 0)
                {
                    throw new ArgumentException("Each teacher must have at least one discipline!");
                }
                else
                {
                    this.disciplines = value;
                }
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.DisciplinesList.Add(discipline);
        }

        public void RemoveDiscipline(Discipline dicipline)
        {
            this.DisciplinesList.Remove(dicipline);
        }

        public List<string> Comment
        {
            get
            {
                return this.comment;
            }
        }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        public string ShowComments()
        {
            var result = string.Empty;
            for (int i = 0; i < comment.Count; i++)
            {
                result += comment[i] + "\n\r";
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0} {1} \r\nDisciplines description: \r\n{2}", this.FirstName, this.LastName, string.Join("\r\n", this.DisciplinesList));
        }
    }
}
