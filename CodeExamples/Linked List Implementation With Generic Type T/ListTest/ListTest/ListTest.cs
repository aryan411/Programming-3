// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibrary;

// class to test List class functionality
class ListTest
{
   static void Main()
   {
      var list = new List<string>(); // create List container

      // create data to store in List
      //bool aBoolean = true;
      //char aCharacter = '$';
      //int anInteger = 34567;
      //string aString = "hello";

      // use List insert methods       
      list.InsertAtFront("Sujeet");
      list.Display();
      list.InsertAtFront("Rick");
      list.Display();
      list.InsertAtBack("Centennial");
      list.Display();
      list.InsertAtBack("Java");
      list.Display();

        // remove data from list and display after each removal
        try
      {
         object removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();
      }
      catch (EmptyListException emptyListException)
      {
         Console.Error.WriteLine($"\n{emptyListException}");
      }
   }
}

