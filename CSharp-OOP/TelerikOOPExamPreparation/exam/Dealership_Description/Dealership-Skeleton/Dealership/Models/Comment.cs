using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;
        private string author;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength, Constants.StringMustBeBetweenMinAndMax);

                this.content = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                this.author = value;
            }
        }
    }
}
