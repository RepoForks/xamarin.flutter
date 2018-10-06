using System;
using System.Collections.Generic;

namespace Dart2CSharpTranspiler.Parser
{

    public class Iterable<T>: List<T>
    {

    }

    public class Comparable<T>
    {

    }
    public class Comparator<T>
    {

    }

    public static class DartLibrary
    {
        public static bool identical(string first, string second)
        {
            return first == second;
        }

        public static bool identical(Expression first, Expression second)
        {
            return first == second;
        }

        public static bool identical(Token first, Token second)
        {
            return first == second;
        }

        public static bool identical(object first, object second)
        {
            return first == second;
        }

        public class StringBuffer
        {
            string value = "";

            public void writeCharCode(int @char)
            {
                value += Convert.ToChar(@char);
            }

            public void write(string text)
            {
                value += text;
            }

            public void write(int text)
            {
                value += text.ToString();
            }

            public String toString()
            {
                return value;
            }
        }
    }
}
