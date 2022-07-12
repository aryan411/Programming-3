// Fig. 19.17: QueueTest.cs
// Testing class QueueInheritance.
using System;
using QueueInheritanceLibrary;
using LinkedListLibrary;

// demonstrate functionality of class QueueInheritance
class QueueTest
{
   static void Main()
   {
      QueueInheritance queue = new QueueInheritance();

      // create objects to store in the queue
      bool aBoolean = true;
      char aCharacter = '$';
      int anInteger = 34567;
      string aString = "hello";

      // use method Enqueue to add items to queue
      queue.Enqueue(aBoolean);
      queue.Display();
      queue.Enqueue(aCharacter);
      queue.Display();
      queue.Enqueue(anInteger);
      queue.Display();
      queue.Enqueue(aString);
      queue.Display();

      // use method Dequeue to remove items from queue
      object removedObject = null;

      // remove items from queue
      try
      {
         while (true)
         {
            removedObject = queue.Dequeue();
            Console.WriteLine($"{removedObject} dequeued");
            queue.Display();
         }
      }
      catch (EmptyListException emptyListException)
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine(emptyListException.StackTrace);
      }
   }
}

