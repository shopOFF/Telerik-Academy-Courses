using Academy.Core.Providers;
using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public abstract class Resource : ILectureResouce
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 15;
        private const int MinURLLength = 5;
        private const int MaxURLLength = 150;


        private string name;
        private string type;
        private string url;

        public Resource(string type, string name, string url)
        {
            this.Name = name;
            this.Type = type;
            this.Url = url;
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Resource name should be between 3 and 15 symbols long!");
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, "Resource name should be between 3 and 15 symbols long!");
                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Resource url should be between 5 and 150 symbols long!");
                Validator.CheckIfStringLengthIsValid(value, MaxURLLength, MinURLLength, "Resource url should be between 5 and 150 symbols long!");
                this.url = value;
            }
        }


        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("    * Resource:");
            sb.AppendLine(string.Format("     - Name: {0}", this.Name));
            sb.AppendLine(string.Format("     - Url: {0}", this.Url));
            sb.AppendLine(string.Format("     - Type: {0}", this.Type));
            sb.AppendLine(string.Format("     - Uploaded on: {0}", DateTimeProvider.Now));

            return sb.ToString();
        }
    }
}
