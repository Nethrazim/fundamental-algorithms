using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FundamentalAlgorithms.Lists.Linked_Lists
{
    public static class AlgoFile
    {
        public static int calculateLength<T>(T[] values)
        {
            Node<T> head = Samples.populateALinkedList(values);
            
            Node<T>? node = head;

            int length = 0;

            while (node != null) {
                length++;

                node = node.Next;
            }

            return length;
        }

        public static Node<T> deleteFirstFoundNode<T>(T[] values, T nodeValue)
        {
            Node<T> node = Samples.populateALinkedList(values);

            Node<T> head = node;
            Node<T>? previous = null;

            while (node != null)
            {
                if (node.Value.Equals(nodeValue))
                {
                    if (previous == null)
                    {
                        head = node.Next;
                        break;
                    }
                    else
                    {
                        previous.Next = node.Next;
                        break;
                    }
                }
                previous = node;
                node = node.Next;
            }

            return head;
        }

        public static Node<T> deleteAllOccurences<T>(T[] values, T nodeValue)
        {
            Node<T> node = Samples.populateALinkedList(values);
            Node<T> head = node;
            Node<T>? previous = null;

            while (node != null)
            {
                if (node.Value.Equals(nodeValue))
                {
                    if (previous == null)
                    {
                        head = node.Next;
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else {
                    previous = node;
                    
                }
                node = node.Next;
            }

            return head;
        }

        public static Node<T> deleteAllOccurences<T>(T[] values, T[] valuesToRemove)
        {
            Node<T> node = Samples.populateALinkedList(values);
            Node<T> head = node;
            Node<T>? previous = null;

            while (node != null)
            {
                if (valuesToRemove.Contains(node.Value))
                {
                    if (previous == null)
                    {
                        head = node.Next;
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;

                }
                node = node.Next;
            }

            return head;
        }

        public static Node<T> insertTail<T>(T[] values, Node<T> tail)
        {
            Node<T> node = Samples.populateALinkedList(values);
            Node<T> head = node;

            while (node != null && node.Next != null) 
            {
                node = node.Next;
            }

            node.Next = tail;

            return head;
        }

        public static Node<T> insertHead<T>(T[] values, Node<T> newHead)
        {
            Node<T> node = Samples.populateALinkedList(values);
            newHead.Next = node;
            return newHead;
        }

        public static Node<T> insertAtSpecificPosition<T>(T[] values, Node<T> newNode, int position)
        {
            Node<T> node = Samples.populateALinkedList(values);
            Node<T> head = node;
            Node<T> previous = null;

            int pos = 1;

            while (node != null) {
                if (pos == position) {
                    if (pos == 1)
                    {
                        newNode.Next = node;
                        return newNode;
                    }
                    else
                    {
                        previous.Next = newNode;
                        newNode.Next = node;
                    }
                }

                previous = node;
                node = node.Next;
                pos++;
            }

            return head;
        }

        public static Node<T> searchForNode<T>(T[] values, T value)
        {
            Node<T> node = Samples.populateALinkedList(values);
            if (node.Value.Equals(value)) {
                return node;
            }

            do
            {
                node = node.Next;
                if (node.Value.Equals(value))
                {
                    return node;
                }
            } while (node.Next != null);

            return null;
        }

        public static void printLinkedListFromHeadToTail<T>(Node<T> node)
        {
            if (node == null)
                return;

            Console.Write("Node " + node.Value + " ");
            printLinkedListFromHeadToTail(node.Next);
        }

        public static void printLinkedListFromTailToHead<T>(Node<T> node)
        {
            if (node == null)
                return;
            printLinkedListFromTailToHead(node.Next);
            Console.WriteLine("Node " + node.Value + "");
        }
    }
}
