using FundamentalAlgorithms.Lists.Linked_Lists;

namespace FundamentalAlgorithms
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Linked List Length = {AlgoFile1.calculateLength(new int[] { 1, 2, 3 , 4, 5, 6 })}");
            //Samples.printLinkedList(AlgoFile1.deleteFirstFoundNode(new int[] { 1, 2, 3, 3, 4, 5 }, 5));
            //Samples.printLinkedList(AlgoFile1.deleteAllOccurences(new int[] { 1, 1, 2, 2, 3, 4, 5, 5, 5, 6, 6}, 1));
            //Samples.printLinkedList(AlgoFile1.deleteAllOccurences(new int[] { 1, 1, 2, 2, 3, 4, 5, 5, 5, 6, 6 }, new int[] { 5, 6}));
            Samples.printLinkedList(AlgoFile1.insertTail(new int[] { 1, 2, 3, 4 }, new Node<int>(5)));
            Console.ReadKey();
        }
    }
}
