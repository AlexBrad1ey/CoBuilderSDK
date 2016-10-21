using System;

namespace CoBuilder.Core.Exceptions
{
    public class CoBuilderException : Exception
    {
        public CoBuilderException(Error error, Exception innerException = null) : base(null, innerException)
        {
            Error = error;
        }

        public Error Error { get; }

        public bool IsMatch(string errorCode)
        {
            if (string.IsNullOrEmpty(errorCode))
            {
                throw new ArgumentException("errorCode cannot be null or empty", nameof(errorCode));
            }

            var currentError = Error;

            while (currentError != null)
            {
                if (string.Equals(currentError.Code, errorCode, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                currentError = currentError.InnerError;
            }

            return false;
        }

        public override string ToString()
        {
            return Error?.ToString() ?? "";
        }
    }
}