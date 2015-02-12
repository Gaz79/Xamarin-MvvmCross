using System;

namespace XamCross
{
    public static class Guard
    {
        public static bool IsNotNull<T>(T obj) where T : class
        {
            return !IsNull(obj);
        }

        public static bool IsNull<T>(T obj) where T : class
        {
            return (obj == null);
        }
    }
}