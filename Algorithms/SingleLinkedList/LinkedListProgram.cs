using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            
            // Insert node to the first of list
            singleLinkedList.insertFirst(50);
            singleLinkedList.insertFirst(4);
            singleLinkedList.insertFirst(66);
            singleLinkedList.insertFirst(111);
            singleLinkedList.insertFirst(3);
           
            // Display nodes
            singleLinkedList.displayList();

            // Delete first node
            singleLinkedList.deleteFirst();

            // Display nodes
            singleLinkedList.displayList();

            Console.ReadKey();
        }
    }

    public class SingleLinkedList
    {
        private Node first;

        //First node is empty
        public bool isEmpty()
        {
            return (first == null);
        }

        // Insert to the first
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        // Insert to the last
        public void insertLast(int data)
        {
            Node current = first;

            while (current != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }

        // Delete first node
        public Node deleteFirst()
        {
            Node tmpFirst = first;
            first = first.next;
            return tmpFirst;
        }

        // Display node list
        public void displayList()
        {
            Console.WriteLine("NodeList sorted from first to last");
            Node currrent = first;

            while (currrent !=null)
            {
                currrent.DisplayNode();
                currrent = currrent.next;
            }
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        // Display current node's data
        public void DisplayNode()
        {
            Console.WriteLine(string.Format("<{0}>",data));
        }
    }
    
}
