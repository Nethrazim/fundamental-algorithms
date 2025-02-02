using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalAlgorithms.Lists.Linked_Lists
{
    public static class TestLinkedListsOps
    {
        public static void Run()
        {
            //Console.WriteLine($"Linked List Length = {AlgoFile1.calculateLength(new int[] { 1, 2, 3 , 4, 5, 6 })}");
            //Samples.printLinkedList(AlgoFile1.deleteFirstFoundNode(new int[] { 1, 2, 3, 3, 4, 5 }, 5));
            //Samples.printLinkedList(AlgoFile1.deleteAllOccurences(new int[] { 1, 1, 2, 2, 3, 4, 5, 5, 5, 6, 6}, 1));
            //Samples.printLinkedList(AlgoFile1.deleteAllOccurences(new int[] { 1, 1, 2, 2, 3, 4, 5, 5, 5, 6, 6 }, new int[] { 5, 6}));
            //Samples.printLinkedList(AlgoFile1.insertTail(new int[] { 1, 2, 3, 4 }, new Node<int>(5)));
            /*foreach (Node<double> node in Samples.populateALinkedList(new double[] { 2.2, 2.3, 2.4 }))
            {
                Console.WriteLine("asd " + node.Value);
            }*/
            //Samples.printLinkedList(AlgoFile1.insertHead(new int[] { 1, 2, 3 }, new Node<int>(0)));
            //Samples.printLinkedList(AlgoFile1.insertAtSpecificPosition(new int[] { 1, 2, 4 }, new Node<int>(3), 3));
            //Console.WriteLine($"Node {AlgoFile1.searchForNode(new int[] { 1, 2, 3, 4 }, 4)?.Value}");

            //AlgoFile1.printLinkedListFromHeadToTail(Samples.populateALinkedList(new int[] { 1, 2, 3, 4 }));
            AlgoFile.printLinkedListFromTailToHead(Samples.populateALinkedList(new int[] { 1, 2, 3, 4 }));
        }

    }
}
