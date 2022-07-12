using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    // class to represent one node in a list
    class ListNode<T>
    {
        // automatic read-only property Data
        public T Data { get; private set; }

        // automatic property Next
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    // class List declaration
    public class List<T> where T : IComparable<T>
    {
        private ListNode<T> firstNode;
        private ListNode<T> lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert T at front of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                firstNode = new ListNode<T>(insertItem, firstNode);
            }
        }

        // Insert T at end of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode<T>(insertItem);
            }
        }

        // remove first node from List
        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }

        // remove last node from List
        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode<T> current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
        public T Minimum()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T min = lastNode.Data; // retrieve data
            ListNode<T> test = firstNode;
            T current = firstNode.Data;

            // loop while current.Next is not lastNode
            while (test.Next != lastNode)
            {
                current = test.Data;
                if (current.CompareTo(min) < 0)
                {
                    min = current;
                }
                test = test.Next; // move to next node
            }
            return min; // return removed data
        }
        public T GetLastNode()   //method to get the last number stored
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            return lastNode.Data; // retrieve data

        }
    }

    // class EmptyListException declaration
    public class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name)
           : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner)
           : base(exception, inner) { }
    }
}

