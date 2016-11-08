// ***********************************************************************
// Assembly         : CoBuilder.Common
// Author           : Alex Bradley
// Created          : 06-07-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-20-2016
// ***********************************************************************
// <copyright file="Identifier.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace CoBuilder.Service.Logic
{
    public static class Identifier
    {
        /// <summary>
        /// Extracts the identifier.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.ArgumentException">@Value cannot be null or empty.</exception>
        public static int ExtractId(string identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                throw new ArgumentException(@"Value cannot be null or empty.", nameof(identifier));

            var productId = identifier.Remove(0, "CBProduct".Length);

            if (identifier.Contains("."))
            {
                productId = productId.Remove(0, productId.Length - productId.IndexOf('.'));
            }

            return Convert.ToInt32(productId);
        }

        public static string Generate()
        {
            return "CBProduct";
        }
    }
}