// Fig. 19.15: StackCompositionLibrary.cs  
// StackComposition class encapsulates functionality of class List.
using LinkedListLibrary;

namespace StackCompositionLibrary
{
   // class StackComposition encapsulates List's capabilities
   public class StackComposition
   {
      private List stack;

      // construct empty stack
      public StackComposition()
      {
         stack = new List("stack");
      }

      // add object to stack
      public void Push(object dataValue)
      {
         stack.InsertAtFront(dataValue);
      }

      // remove object from stack
      public object Pop()
      {
         return stack.RemoveFromFront();
      }

      // determine whether stack is empty
      public bool IsEmpty()
      {
         return stack.IsEmpty();
      }

      // output stack contents
      public void Display()
      {
         stack.Display();
      }
   }
}

