using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private const int MinLectureNameLength = 5;
        private const int MaxLectureNameLength = 30;

        private string name;
        private DateTime date;
        private ITrainer trainer;
        private IList<ILectureResouce> resouces;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
            this.resouces = new List<ILectureResouce>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxLectureNameLength, MinLectureNameLength, "Lecture's name should be between 5 and 30 symbols long!");
                this.name = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }

            set
            {
                this.trainer = value;
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                return this.resouces;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" - Lectures:");
            sb.AppendLine("  * Lecture:");
            sb.AppendLine(string.Format("   - Name: {0}", this.Name));
            sb.AppendLine(string.Format("   - Date: {0}", this.Date));
            sb.AppendLine(string.Format("   - Trainer username: {0}", this.Trainer.Username));
            sb.AppendLine(string.Format("   - Resources:"));

            return sb.ToString();
        }
    }
}
