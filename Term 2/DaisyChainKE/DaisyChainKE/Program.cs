using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaisyChainKE
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> FlowerPower = new LinkedList<String> ();

            // Add an item to the front of the list
            FlowerPower.AddFirst("Daisy");

            // Add an item to the back of the list
            FlowerPower.AddLast("Petunia");

            // Add an item to the back of the list
            FlowerPower.AddLast("Rose");

            // print the list to the screen
            printList(FlowerPower);

            // Remove the first item from the list
            FlowerPower.RemoveFirst();

            // print the list to the screen
            printList(FlowerPower);

            // Remove the item named "Rose"
            FlowerPower.Remove("Rose");

            // print the list to the screen
            printList(FlowerPower);

            // Remove ALL the items from the list
            FlowerPower.Clear();

            // print the list to the screen
            printList(FlowerPower);

            // Add some items back to the list
            FlowerPower.AddFirst("Daisy");
            FlowerPower.AddLast("Petunia");
            FlowerPower.AddLast("Rose");

            // print the list to the screen
            printList(FlowerPower);

            // Create a node for the second item in the list
            LinkedListNode<string> middleNode = FlowerPower.First.Next;

            // Add a new flower after the node
            FlowerPower.AddAfter(middleNode, "Tulip");

            // Add a new flower before the node
            FlowerPower.AddBefore(middleNode, "Viola");

            // print the list to the screen
            printList(FlowerPower);

            Console.ReadKey();
        }

        // This code is provided for you. 
        static public void printList(LinkedList<string> List)
        {
            Console.Write("List: ");
            LinkedListNode<string> aNode = List.First;
            while (aNode != null)
            {
                Console.Write(aNode.Value + " ");
                aNode = aNode.Next;
            }
            Console.WriteLine();
        }   
    }
}
