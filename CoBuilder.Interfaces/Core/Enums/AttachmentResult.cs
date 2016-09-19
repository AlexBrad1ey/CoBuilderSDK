using System;

namespace CoBuilder.Service.Enums
{
    [Flags]
    public enum AttachmentResult

    {
        /// <summary>
        /// The null
        /// </summary>
        Null = 0,
        /// <summary>
        /// The no elements connected
        /// </summary>
        NoElementsConnected = 1,
        /// <summary>
        /// All elements connected
        /// </summary>
        AllElementsConnected = 2,
        /// <summary>
        /// Some elements connected
        /// </summary>
        SomeElementsConnected = 3
    }
}