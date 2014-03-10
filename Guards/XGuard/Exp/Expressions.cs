using System;

namespace XGuard.Exp
{
    /// <summary>
    /// Contains a collection of reusable functions that can be used for validation.
    /// </summary>
    internal static class Expressions
    {
        public static readonly Func<object, bool> InstanceNull = (a) => a == null;

        public static readonly Func<object, bool> InstanceEmpty = (a) => a.Equals(string.Empty);
    }
}