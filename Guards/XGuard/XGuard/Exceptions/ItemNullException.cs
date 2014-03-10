using System;

namespace XGuard.Exceptions
{
    /// <summary>
    /// Indicates that the given item is null.
    /// </summary>
    public class ItemNullException : Exception
    {
        public ItemNullException()
        {
        }

        public ItemNullException(string message)
            : base(message)
        {
        }
    }
}