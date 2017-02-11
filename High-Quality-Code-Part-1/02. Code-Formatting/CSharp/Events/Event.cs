namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            var other = obj as Event;
            int sortByDate = this.date.CompareTo(other.date);
            int sortByTitle = this.title.CompareTo(other.title);
            int sortByLocation = this.location.CompareTo(other.location);

            if (sortByDate == 0)
            {
                if (sortByTitle == 0)
                {
                    return sortByLocation;
                }
                else
                {
                    return sortByTitle;
                }
            }
            else
            {
                return sortByDate;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}