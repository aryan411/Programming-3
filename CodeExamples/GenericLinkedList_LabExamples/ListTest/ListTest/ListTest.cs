// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibrary;

// class to test List class functionality
class ListTest
{
   static void Main()
   {
      List<int> list = new List<int>(); // create List container
      List<double> listDouble = new List<double>();
        List<char> listChar = new List<char>();

        // create data to store in List
        // bool aBoolean = true;
        // char aCharacter = '$';
        int anInteger = 34567;
        // string aString = "hello";
        int anInteger2 = 567;
        int anInteger3 = 345;
        int anInteger4 = 67;

        double aDouble1 = 34567.45;
        // string aString = "hello";
        double aDouble2 = 567.23;
        double aDouble3 = 345.78;
        double aDouble4 = 67.89;

        // use List insert methods       
        //list.InsertAtFront(aBoolean);
        list.InsertAtFront(anInteger);
        list.Display();
        // list.InsertAtFront(aCharacter);
        list.InsertAtFront(anInteger2);
        list.Display();
      list.InsertAtBack(anInteger3);
      list.Display();
        //list.InsertAtBack(aString);
        list.InsertAtBack(anInteger4);
        list.Display();

        // ...double values added to the linkedList -listDouble

        listDouble.InsertAtFront(aDouble1);
        listDouble.Display();
        // list.InsertAtFront(aCharacter);
        listDouble.InsertAtFront(aDouble2);
        listDouble.Display();
        listDouble.InsertAtBack(aDouble3);
        listDouble.Display();
        //list.InsertAtBack(aString);
        listDouble.InsertAtBack(aDouble4);
        listDouble.Display();

        // remove data from list and display after each removal
        try
      {
         int removedObject = list.RemoveFromFront();
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
            removedObject = list.RemoveFromBack();
            list.Display();
      }
      catch (EmptyListException emptyListException)
      {
         Console.Error.WriteLine($"\n{emptyListException}");
      } // end catch

        Console.WriteLine($"Demonstration of linked of int type is over");
    } // end main
} // end class

