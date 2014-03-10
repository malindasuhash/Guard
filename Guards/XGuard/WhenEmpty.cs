using System;
using XGuard.Exceptions;
using XGuard.Exp;

namespace XGuard
{
    public static partial class x
    {
        /// <summary>
        /// Throws an <see cref="ItemEmptyException"/> when the given <see cref="instance"/> is empty.
        /// </summary>
        public static void ThrowIfEmpty(string instance)
        {
            ThrowIfNull(instance);

            if (Expressions.InstanceEmpty(instance))
            {
                throw new ItemEmptyException();
            }
        }

        /// <summary>
        /// Throws an <see cref="ItemEmptyException"/> when the given <see cref="instance"/> is empty.
        /// </summary>
        public static void ThrowIfEmpty(string instance, string message)
        {
            ThrowIfNull(instance);
            ThrowIfNull(message);

            if (Expressions.InstanceEmpty(instance))
            {
                throw new ItemEmptyException(message);
            }
        }

        /// <summary>
        /// Throws an <see cref="ItemEmptyException"/> when the given <see cref="instance"/> is empty.
        /// </summary>
        public static void ThrowIfEmpty<T>(string instance) where T : Exception, new()
        {
            ThrowIfNull(instance);

            if (Expressions.InstanceEmpty(instance))
            {
                throw new T();
            }
        }

        /// <summary>
        /// Returns <c>true</c> if the given <see cref="instance"/> is an empty string.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static bool IsEmptySpace(string instance)
        {
            if (Expressions.InstanceNull(instance))
            {
                return false;
            }

            return Expressions.InstanceEmpty(instance.Trim());
        }
    }
}
