using System;
using System.Diagnostics;

namespace Testdome_CSharp {

    public class BinarySearchTree {
        public class Node {
            public int Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }

            public Node(int value, Node left, Node right) {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        public static bool Contains(Node root, int value) {
            while (true) {
                if (root.Value == value)
                    return true;
                else if (root.Value < value) {
                    if (root.Right == null)
                        return false;
                    root = root.Right;
                }
                else {
                    if (root.Left == null)
                        return false;
                    root = root.Left;
                }
            }
        }

        //public static void Main(string[] args) {

        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();

        //    Node n1 = new Node(1, null, null);
        //    Node n3 = new Node(3, null, null);
        //    Node n2 = new Node(2, n1, n3);
        //    Console.WriteLine(Contains(n2, 3));

        //    stopWatch.Stop();
        //    Console.WriteLine("time: " + stopWatch.ElapsedMilliseconds + "ms");
        //    // takes 13ms 
        //}
    }
}

