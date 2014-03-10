using System;

namespace XGuard.Exceptions
{
    public class ItemEmptyException : Exception
    {
        public ItemEmptyException()
        {
        }

        public ItemEmptyException(string message)
            : base(message)
        {
        }
    }
}