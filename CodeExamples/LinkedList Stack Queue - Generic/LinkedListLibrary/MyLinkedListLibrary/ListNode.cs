using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListLibrary
{
    public class ListNode<T>
    {
        // automatic read-only property Data
       // public int Data { get; private set; }
        public T Data { get; private set; }

        // automatic property Next
       // public ListNode Next { get; set; }
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
       // public ListNode(int dataValue) : this(dataValue, null) { }
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        //public ListNode(int dataValue, ListNode nextNode)
        //{
        //    Data = dataValue;
        //    Next = nextNode;
        //}
        // Generic
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
} // end ListNode
