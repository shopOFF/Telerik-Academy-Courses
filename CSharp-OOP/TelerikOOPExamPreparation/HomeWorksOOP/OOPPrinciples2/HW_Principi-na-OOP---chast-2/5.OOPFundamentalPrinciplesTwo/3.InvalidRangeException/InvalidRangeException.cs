using System;


namespace _3.InvalidRangeException
{
    public class InvalidRangeException<T> : Exception
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
       //Properties
        public T StartRange { get; private set; }
        public T EndRange { get; private set; }

        // Constructor
        public InvalidRangeException(T startRange, T endRange)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
        public InvalidRangeException(T startRange, T endRange, string message)
            : base(message)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
        public InvalidRangeException(T startRange, T endRange, string message, Exception innerException)
            : base(message, innerException)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }


    }
}
