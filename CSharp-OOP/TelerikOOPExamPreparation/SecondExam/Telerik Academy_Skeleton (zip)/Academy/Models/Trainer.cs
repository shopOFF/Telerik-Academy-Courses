using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : ITrainer, IUser
    {
        private const int MinTrainerNameLength = 3;
        private const int MaxTrainerNameLength = 16;

        private string username;
        private IList<string> technologies;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(';').ToList();  // or - new List<string>() { technologies };
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "User's username should be between 3 and 16 symbols long!");
                Validator.CheckIfStringLengthIsValid(value, MaxTrainerNameLength, MinTrainerNameLength, "User's username should be between 3 and 16 symbols long!");
                this.username = value;
            }
        }

        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }

            set
            {
                this.technologies = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("* Trainer:");
            sb.AppendLine(string.Format(" - Username: {0}", this.Username));
            sb.Append(string.Format(" - Technologies: {0}", string.Join(",", this.Technologies )));

            return sb.ToString();
        }
    }
}
