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

    public static partial class DartLibrary
    {

        public static void assert(bool condition)
        {

        }

        public static bool isEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool isEmpty<T>(this List<T> value)
        {
            return value?.Count == 0;
        }

        public static void forEach<K, V>(this Dictionary<K, V> dictionary, Action<K, V> action)
        {
            foreach (var item in dictionary)
                action(item.Key, item.Value);
        }

        public static void addAll<T>(this List<T> list, List<T> add)
        {
            foreach (var item in add)
                list.Add(item);
        }

        public static void addAll<K, V>(this Dictionary<K, V> dictionary, Dictionary<K, V> add)
        {
            foreach (var item in add)
                dictionary.Add(item.Key, item.Value);
        }

        public static V putIfAbsent<K, V>(this Dictionary<K, V> dictionary, K key, Func<V> value)
        {
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value());

            return dictionary[key];
        }

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
