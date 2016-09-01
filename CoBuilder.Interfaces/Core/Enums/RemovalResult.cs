using System;

namespace CoBuilder.Service.Enums
{
    [Flags]
    public enum RemovalResult
    {
        /// <summary>
        /// The null
        /// </summary>
        Null = 0,
        /// <summary>
        /// The no elements disconnected
        /// </summary>
        NoElementsDisconnected = 1,
        /// <summary>
        /// All elements disconnected
        /// </summary>
        AllElementsDisconnected = 2,
        /// <summary>
        /// Some elements disconnected
        /// </summary>
        SomeElementsDisconnected = 3
    }
}