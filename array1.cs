// arrays are a collection of variables of the same data type that are accessed through a common name.
// //They have a fixed length and are stored in contiguous memory locations.
//arrays in c# are represented by the Array class which provides methods to manipulate the collections of elements .
//arrays are declared using square brackets [] after the variable name.eg->int[] x, string[] cars;
//string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//types of array->  1.one -dimensional 
//     2.two - dimensional :- a multi dimensional array that stores data in a matrix format with rows and coloumns.
// ie . number of column should be equal of each row.
// int [,] =new int [row,col]   
//  int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

//      3.Jagged Array-> multidimensional array which rows have different number of elements.

//Jagged array is a array of arrays such that member arrays can be of different sizes.
//In other words, the length of each array index can differ. The elements of Jagged Array are reference types and initialized to null by default. Jagged Array can also be mixed with multidimensional arrays.
//      jagged array is an array of arrays.  eg-> int[][] jagged_arr = new int[4][]

/*int[][] jagged_arr = 
{
    new int[] { 1, 2, 3, 4 },
    new int[] { 11, 34, 67 },
    new int[] { 89, 23 },
    new int[] { 0, 45, 78, 53, 99 }
};
/*/

//      4.Object Array(Dynamic array):--Object array is used to store elements of the different types in a single array.
//




using System;
public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];//creating array  
        arr[0] = 10;//initializing array  
        arr[2] = 20;
        arr[4] = 30;

        //traversing array  
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
