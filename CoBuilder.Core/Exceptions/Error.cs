// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="Error.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Text;

namespace CoBuilder.Core.Exceptions
{
    /// <summary>
    /// Class Error.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the inner error.
        /// </summary>
        /// <value>The inner error.</value>
        public Error InnerError { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var errorStringBuilder = new StringBuilder();

            if (!string.IsNullOrEmpty(Code))
            {
                errorStringBuilder.AppendFormat("Code: {0}", Code);
                errorStringBuilder.Append(Environment.NewLine);
            }

            if (!string.IsNullOrEmpty(Message))
            {
                errorStringBuilder.AppendFormat("Message: {0}", Message);
                errorStringBuilder.Append(Environment.NewLine);
            }

            if (InnerError != null)
            {
                errorStringBuilder.Append(Environment.NewLine);
                errorStringBuilder.Append("Inner error");
                errorStringBuilder.Append(Environment.NewLine);
                errorStringBuilder.Append(InnerError);
            }

            return errorStringBuilder.ToString();
        }
    }
}