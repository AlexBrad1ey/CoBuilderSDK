// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="CoBuilderException.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace CoBuilder.Core.Exceptions
{
    /// <summary>
    /// Class CoBuilderException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class CoBuilderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderException"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="innerException">The inner exception.</param>
        public CoBuilderException(Error error, Exception innerException = null) : base(null, innerException)
        {
            Error = error;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>The error.</value>
        public Error Error { get; }

        /// <summary>
        /// Determines whether the specified error code is match.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <returns><c>true</c> if the specified error code is match; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.ArgumentException">errorCode cannot be null or empty</exception>
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

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return Error?.ToString() ?? "";
        }
    }
}