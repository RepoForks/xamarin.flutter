using System;
using System.Collections.Generic;
using System.Linq;

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
        int _value = 0;
        public Comparator(int value) => _value = value;
    }

    public static class DartLibrary
    {

        public static int codeUnitAt(this string value, int index)
        {
            return System.Text.Encoding.Unicode.GetBytes(value)[index];
        }

        public static int compareTo(this string first, string second)
        {
            var sort = new List<string>
            { first, second };

            if (sort.OrderBy(x => x).First() == first)
                return -1;
            else
                return 1;
        }

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

            public void writeln()
            {
                value += "\n";
            }

            public String toString()
            {
                return value;
            }
        }
    }
}
