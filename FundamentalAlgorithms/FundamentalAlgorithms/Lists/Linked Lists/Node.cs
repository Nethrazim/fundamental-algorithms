using FundamentalAlgorithms.Lists.Linked_Lists;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalAlgorithms.Lists.Linked_Lists
{
    public class Node<T> : IEnumerable<Node<T>>
    {
        public T Value { get; set; }

        public Node<T>? Next { get; set; }

        public Node(T value) {
            Value = value;
        }

        public Node() { }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> current = this;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

    }


    public static class Samples
    {
        public static Node<T> populateALinkedList<T>(T[] values) {
            if (!values.Any())
                return null;

            Node<T> head = new Node<T>(values[0]);
            Node<T> tail = head;
            for (int i = 1; i < values.Length; i++)
            {
                var node = new Node<T>(values[i]);
                tail.Next = node;
                tail = node;
            }

            return head;
        }

        public static void printLinkedList<T>(Node<T> node)
        {
            while (node != null)
            {
                Console.Write($"Node {node.Value} ");
                node = node.Next;
            }

            Console.WriteLine("");
        }
    }
}