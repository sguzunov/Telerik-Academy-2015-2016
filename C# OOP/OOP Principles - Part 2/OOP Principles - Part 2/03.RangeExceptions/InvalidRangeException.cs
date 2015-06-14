namespace RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }

        public InvalidRangeException(string message, T start, T end, Exception ex)
            : base(message, ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        { 
        }
    }
}
