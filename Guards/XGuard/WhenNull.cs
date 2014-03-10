using System;
using XGuard.Exceptions;
using XGuard.Exp;

namespace XGuard
{
    public static partial class x
    {
        /// <summary>
        /// Throws an <see cref="ItemNullException"/> when the given <see cref="instance"/> is null.
        /// </summary>
        public static void ThrowIfNull(object instance)
        {
            if (Expressions.InstanceNull(instance))
            {
                throw new ItemNullException();
            }
        }

        /// <summary>
        /// Throws an <see cref="ItemNullException"/> when the given <see cref="instance"/> is null with <see cref="message"/>.
        /// </summary>
        public static void ThrowIfNull(object instance, string message)
        {
            ThrowIfNull(message);

            if (Expressions.InstanceNull(instance))
            {
                throw new ItemNullException(message);
            }
        }

        /// <summary>
        /// Throws an <see cref="T"/> when the given <see cref="instance"/> is null.
        /// </summary>
        public static void ThrowIfNull<T>(object instance) where T : Exception, new()
        {
            if (Expressions.InstanceNull(instance))
            {
                throw new T();
            }
        }

        /// <summary>
        /// Returns <c>true</c> if the instance is null.
        /// </summary>
        public static bool IsNull(object instance)
        {
            return Expressions.InstanceNull(instance);
        }
    }
}