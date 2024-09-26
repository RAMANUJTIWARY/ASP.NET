// collection:- Collections are objects that store and manipulate groups of data in c#.
// non generic collection:- arraylist,hashtable,sortedlist,stack,queue.


// ArrayList is class which is combination of array and list.
//ArrayList:- predeined Properties
1.Capacity:-
2.Count:-
3.Add:-add object at the end
4.Clear():-removes all elements from the ArrayList.
5. a.Remove(ObjectName):- Removes the first occurrence of a specific object from the ArrayList.
  b.RemoveAt(Int32):-Removes the element at the specified index of the ArrayList.
6.a.Reverse():-Reverses the order of the elements in the entire ArrayList.
   b.Reverse(Int32, Int32)	:-Reverses the order of the elements in the specified range.
7.Sort():-


// HashTable:- stored data in key value pair.

// SortedList:- SortedList is also stored data in key value pair but it sort the data after storing
// stack:- it follow the last in first out (LIFO) rule.
// Queue:-it follow the FIRST IN FIRST OUT (FIFO)
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// collection:- Collections are objects that store and manipulate groupps of data in c#.
// non generic collection:- arraylist,hashtable,sortedlist,stack,queue.


// ArrayList is class which is combination of array and list.
// HashTable:- stored data in key value pair.
// SortedList:- SortedList is also stored data in key value pair but it sort the data after storing
// stack:- it follow the last in first out (LIFO) rule.
// Queue:-it follow the FIRST IN FIRST OUT (FIFO)

// Generic Collection:- in generic where we need typed data.in the generic.it stores specific type . collection we have List,Dictionary
using System.Collections;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       /*ArrayList obj=new ArrayList();
       obj.Add(1);
       obj.Add("c");
       obj.Add("java");
       obj.Add("45.6");
       foreach(object i in obj){
           Console.WriteLine(i);*/
           
           
        // Hashtable ht=new Hashtable();
        // ht.Add("ram","ayodhya");
        // ht.Add("sita","janakpur");
        // foreach(DictionaryEntry entry in ht){
        //     Console.WriteLine(entry.Key+" , "+entry.Value);
        // }
        
        // Stack st =new Stack();
        // st.push(1);
        // st.push(2);
        // st.push(3);
        // foreach(var item in st){
        //     ConsoleWriteLine(item);
        // // }
        // Queue q=new Queue();
        // q.Enqueue(1);
        // q.Enqueue(2);
        // q.Enqueue(3);
        // foreach(var i in q){
        //     Console.WriteLine(i);
        // }   
        
        List<int>list=new List<int>();
        list.Add(2);
        list.Add(4);
        
       }
       
    }




using System.Collections;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       ArrayList obj=new ArrayList();
       obj.Add(1);
       obj.Add("c");
       obj.Add("java");
       obj.Add("45.6");

       foreach(object i in obj){
           Console.WriteLine(i);
       }
       
    }

}
