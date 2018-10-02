using System;

namespace Dart2CSharpTranspiler
{
    public class StringUtilities
    {
        public static Interner INTERNER = new NullInterner();

        public static String intern(String @string) => INTERNER.intern(@string);
    }
}
