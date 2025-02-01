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
    public class AlgoFile1
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
    }
}
