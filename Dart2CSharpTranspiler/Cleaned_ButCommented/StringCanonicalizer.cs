using System;
using System.Collections.Generic;
using System.Text;

// https://github.com/dart-lang/sdk/blob/master/pkg/front_end/lib/src/fasta/scanner/string_canonicalizer.dart

namespace Dart2CSharpTranspiler.Parser
{
    // import 'dart:convert';

    public class Node
    {
        Object data;
        int start;
        int end;
        String payload;
        Node next;
        public Node(Object data, int start, int end, String payload, Node next)
        {
            this.data = data;
            this.start = start;
            this.end = end;
            this.payload = payload;
            this.next = next;
        }
    }

    /// A hash table for triples:
    /// (list of bytes, start, end) --> canonicalized string
    /// Using triples avoids allocating string slices before checking if they
    /// are canonical.
    ///
    /// Gives about 3% speedup on dart2js.
    public class StringCanonicalizer
    {
        /// Mask away top bits to keep hash calculation within 32-bit SMI range.
        public const int MASK = 16 * 1024 * 1024 - 1;

        public const int INITIAL_SIZE = 8 * 1024;

        /// Linear size of a hash table.
        int _size = INITIAL_SIZE;

        /// Items in a hash table.
        int _count = 0;

        /// The table itself.
        List<Node> _nodes = new List<Node>(INITIAL_SIZE);

        static String decode(List<int> data, int start, int end, bool asciiOnly)
        {
            //System.Text.UTF8Encoding.Convert()
            String s = "";
            //if (asciiOnly)
            //{

            for (int i = start; i < end; i++)
                s += Convert.ToChar(data[i]);
            //}
            //else
            //{
            //    s = new Utf8Decoder(allowMalformed: true).convert(data, start, end);
            //}
            return s;
        }

        public static int hashBytes(List<int> data, int start, int end)
        {
            int h = 5381;
            for (int i = start; i < end; i++)
            {
                h = ((h << 5) + h + data[i]) & MASK;
            }
            return h;
        }

        //public static int hashString(String data, int start, int end)
        //{
        //    int h = 5381;
        //    for (int i = start; i < end; i++)
        //    {
        //        h = ((h << 5) + h + data.codeUnitAt(i)) & MASK;
        //    }
        //    return h;
        //}

        //public void rehash()
        //{
        //    var newSize = _size * 2;
        //    var newNodes = new List<Node>(newSize);
        //    for (int i = 0; i < _size; i++)
        //    {
        //        Node t = _nodes[i];
        //        while (t != null)
        //        {
        //            Node n = t.next;
        //            int newIndex = t.data is String
        //                ? hashString(t.data, t.start, t.end) & (newSize - 1)
        //                : hashBytes(t.data, t.start, t.end) & (newSize - 1);
        //            Node s = newNodes[newIndex];
        //            t.next = s;
        //            newNodes[newIndex] = t;
        //            t = n;
        //        }
        //    }
        //    _size = newSize;
        //    _nodes = newNodes;
        //}

        //public String canonicalize(data, int start, int end, bool asciiOnly)
        //{
        //    if (_count > _size) rehash();
        //    int index = data is String
        //        ? hashString(data, start, end)
        //        : hashBytes(data, start, end);
        //    index = index & (_size - 1);
        //    Node s = _nodes[index];
        //    Node t = s;
        //    int len = end - start;
        //    while (t != null)
        //    {
        //        if (t.end - t.start == len)
        //        {
        //            int i = start, j = t.start;
        //            while (i < end && data[i] == t.data[j])
        //            {
        //                i++;
        //                j++;
        //            }
        //            if (i == end)
        //            {
        //                return t.payload;
        //            }
        //        }
        //        t = t.next;
        //    }
        //    String payload;
        //    if (data is String)
        //        payload = data.substring(start, end);
        //    else
        //        payload = decode(data, start, end, asciiOnly);
        //    _nodes[index] = new Node(data, start, end, payload, s);
        //    _count++;
        //    return payload;
        //}

        public void clear()
        {
            _size = INITIAL_SIZE;
            _nodes = new List<Node>(_size);
            _count = 0;
        }
    }
}
