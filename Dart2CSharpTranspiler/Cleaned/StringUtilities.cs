using System;

namespace Dart2CSharpTranspiler
{
    public class StringUtilities
    {
        public static Interner INTERNER = new NullInterner();

        public static String intern(String @string) => INTERNER.intern(@string);

        public static bool startsWithChar(string value, int @char)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            return value.ToCharArray()[0] == (char)@char;
        }
    }
}
