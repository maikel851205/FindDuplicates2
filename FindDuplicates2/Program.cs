using System;
using System.Collections.Generic;

namespace FindDuplicates2
{
    class Program


        //The question is there is and 
        //unsorted array and the maximum value should be smaller than the length.
        //I have to find the duplicate record in the array.The condition is to use a loop only once. 
        //    This is what i have achieved so far. 
        //    I wanted to know if there was any other approach through which i can achieve this.


        // stackoverflow website.
        //        The question is there is and unsorted array and the maximum value should be smaller than the length.

    //Also assuming only positive numbers, which in your example applies

    //This can be done using O(n) time and O(1) space without using any LINQ, Dictionary, Hashing etc.



    {


        static void Main(string[] args)
        {

            // working with indeces. 1st aproach.

            //int[] arr = { 9, 5, 6, 3, 8, 2, 5, 1, 9, 4 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[Math.Abs(arr[i])] >= 0)
            //        arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
            //    else
            //        Console.WriteLine("Duplicate found " + Math.Abs(arr[i]).ToString() + "\n");
            //}
            //Console.ReadLine();


            //2nd aproach. working with indeces.

            //int[] Arr = { 9, 5, 6, 3, 8, 2, 5, 1, 7, 4 };
            //int[] Arr2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (Arr2[Arr[i]] == 0)
            //    {
            //        Arr2[Arr[i]] = Arr[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine("duclicate found " + Arr2[Arr[i]]);
            //    }
            //}
            //Console.ReadLine();



            //            C# | HashSet Class
            //A HashSet<T> is an unordered collection of the unique elements.It comes under System.Collections.Generic namespace.It is used in a situation where we want to prevent duplicates from being inserted in the collection.As far as performance is concerned, it is better in comparison to the list.


            //Characteristics of HashSet Class:


            //The HashSet<T> class provides high-performance set operations.A set is a collection that contains no duplicate elements, and whose elements are in no particular order.
            //The capacity of a HashSet<T> object is the number of elements that the object can hold.
            //A HashSet<T> object’s capacity automatically increases as elements are added to the object.
            //A HashSet<T> collection is not sorted and cannot contain duplicate elements.
            //HashSet<T> provides many mathematical set operations, such as set addition (unions) and set subtraction.



            // 3rd aproach. Working with hashset


         //HashSet<int> hs = new HashSet<int>();
         //int[] Arr = { 9, 5, 6, 3, 8, 2, 5, 1, 7, 4 };

         //foreach(var item in Arr)
         //{
         //    if (hs.Contains(item))h
         //    {
         //        Console.WriteLine("duplicate found " + item);
         //        // break; // <- uncomment this if you want one message only
         //    }
         //    else
         //        hs.Add(item);
         //}
         //Console.ReadLine();


         //4th aproach. Working with HashSet.

         //since hs.Add returns bool a shorter and more efficient code can be put:

         HashSet<int> hs = new HashSet<int>();
            int[] Arr = { 9, 5, 6, 3, 8, 2, 5, 1, 7, 9 };

            foreach (var item in Arr)
                if (!hs.Add(item))
                {
                    Console.WriteLine("duplicate found " + item);
                    // break; // <- uncomment this if you want one message only
                }
            Console.ReadLine();
        }







    }
}
