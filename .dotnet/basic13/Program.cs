using System;
using System.Collections.Generic;   


namespace basic13
{
    class Program
    {
// Print all of the integers from 1 to 255.
        // static void Main(string[] args)        
        // {
        //     for(int i = 0; i <= 255; i++)
        //     {
        //         Console.WriteLine(i);
        //     }        
        // }
// Print all of the odd integers from 1 to 255.
        // static void Main(string[] args)
        // {
        //     for(int i = 0; i <=255;i++)
        //     {
        //         if (i%2 == 1)
        //         {
        //             Console.WriteLine(i);
        //         }
        //     }
        // }
// Print Sum Print all of the numbers from 0 to 255, 
        // static void Main(string[] args)
        // {
        //     int sum = 0;
        //     for(int i = 0; i <=255;i++)
        //     {
        //         sum += i;
        //         Console.WriteLine("New Number:{0}, sum:{0}",i,sum);
        //     }
        // }
// Write a function that would iterate through each item of the given integer array and print each value to the console. 
//         static void Main(string[] args)
//         {
//             int[] arr = {1, 2, 3, 4};
//             foreach (var val in arr)
//             {
//                 Console.WriteLine(val);
//             }
//         }
//     }
// }
// Write a function that takes an integer array and prints and returns the maximum value in the array, Find Max.
        // static void Main(string[] args)
//         {
//             int[] arr = {1, 2, 3, 4};
//             int max = arr[0];
//             foreach (var maxNum in arr)
//             {
//                 if (maxNum > max)
//                 {
//                     max = maxNum;
//                 }
//             }
//             Console.WriteLine("Max: " + max);
//         }
//     }
// }
// Get Average and Write a program that takes an array, and prints the AVERAGE of the values in the array. 
    //     static int Main(string[] args)
    //             {
    //                 int[] arr = {1, 2, 3, 4};
    //                 int arrSum = arr[0];
    //                 foreach (int num in arr)
    //                 {
    //                     arrSum += num;
    //                 }
    //                 int arrAvg = arrSum/arr.Length;
    //                 Console.WriteLine($"average is {arrAvg}");
    //                 return arrAvg;
    //             }
    // }
// }
// Array with Odd Numbers and Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255. When the program is done, 'y' should have the value of [1, 3, 5, 7, ... 255].
//         static void Main(string[] args)
//         {
//             var y = new List<int>();
//             for (int i = 1; i < 256; i++)
//             {
//                 if (i % 2 == 1)
//                 {
//                     y.Add(i);
//                 }
//             }

//             Console.WriteLine("array y: ");
//             foreach (var i in y)
//             {
//                 Console.Write( + i +"  ");
//             }
//         }
//     }
// }
// Greater than Y and Write a program that takes an array and returns the number of values in that array whose value is greater than a given value y. For example, if array = [1, 3, 5, 7] and y = 3. After your program is run it will print 2 (since there are two values in the array that are greater than 3).



                            // Help



// Square the Values and Given any array x, say [1, 5, 10, -2], create an algorithm (sets of instructions) that multiplies each value in the array by itself. When the program is done, the array x should have values that have been squared, say [1, 25, 100, 4].
//             static void Main(string[] args)
//             {
//                 int[] arr = {1, 2, 3, 4};
//                 for (int i = 0; i < arr.Length; i++)
//                 {
//                     arr[i] = arr[i] * arr[i];
//                 }

//                 Console.Write("Squared: ");
//                 foreach (var val in arr)
//                 {
//                     Console.Write(val + ", ");
//                 }
//                 Console.WriteLine("");
//             }
//     }
// }
// Eliminate Negative Numbers and Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any negative number with the value of 0. When the program is done, x should have no negative values, say [1, 5, 10, 0].
//             static void Main(string[] args)
//             {
//                 int[] arr = {-1, 2, 3, -4};
//                 for (int i = 0; i < arr.Length; i++)
//             {
//                 if (arr[i] < 0)
//                 {
//                     arr[i] = 0;
//                 }
//             }

//             Console.WriteLine("Array with no negs:");
//             foreach (var i in arr)
//             {
//                 Console.Write(i + ", ");
//             }
//         }
//     }
// }
// Min, Max, and Average and Given any array x, say [1, 5, 10, -2], create an algorithm that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
//         static void Main(string[] args)
//         {
//             // FindMax(arr);            
//             int[] arr = {1, 2, 3, 4};
//             int max = arr[0];
//             foreach (var maxNum in arr)
//             {
//                 if (maxNum > max)
//                 {
//                     max = maxNum;
//                 }
//             }
//             Console.WriteLine("Max: " + max);
//             // GetMin(arr);
//             int min = arr[0];
//             for (int i = 1; i < arr.Length; i++)
//                 {
//                     if (arr[i] < min)
//                     {
//                         min = arr[i];
//                     }
//                 }
//             Console.WriteLine("Min: " + min);
//             // GetAvg(arr);
//             int arrSum = arr[0];
//             foreach (int num in arr)
//                 {
//                     arrSum += num;
//                 }
//             int arrAvg = arrSum/arr.Length;
//             Console.WriteLine("Average:" + arrAvg);
//                 // return arrAvg;
//         }
//     }
// }
// Shifting the values in an array and Given any array x, say [1, 5, 10, 7, -2], create an algorithm that shifts each number by one to the front and adds '0' to the end. For example, when the program is done,  if the array [1, 5, 10, 7, -2] is passed to the function, it should become [5, 10, 7, -2, 0].
//         static void Main(string[] args)
//         {
//             List<object> dojoList = new List<object>();
//             {
//                 dojoList.Add(1);
//                 dojoList.Add(2);
//                 dojoList.Add(3);
//                 dojoList.Add(4);
//                 dojoList.Add(5);
//                 foreach (var obj in dojoList)
//                 Console.WriteLine(obj);
//             }
//                 dojoList.RemoveAt(0);
//                 dojoList.Add(0);
//                 Console.Write("[ ");
//                     foreach (var obj in dojoList)
//                     {
//                         Console.Write(obj + "  ");
//                     }
//             Console.WriteLine("]");
//         }
//     }
// }

 // Number to String and Write a program that takes an array of numbers and replaces any negative number with the string 'Dojo'. For example, if array x is initially [-1, -3, 2] your function should return an array with values ['Dojo', 'Dojo', 2]
//         static void Main(string[] args)
//         {
//             List<object> dojoList = new List<object>();
//             {
//                 dojoList.Add(-1);
//                 dojoList.Add(2);
//                 dojoList.Add(3);
//                 dojoList.Add(-4);
//                 dojoList.Add(-5);
//                 foreach (var obj in dojoList)
//                 Console.WriteLine(obj);
//             }
//             {
//                 for (int i = 0; i < dojoList.Count; i++)
//                 {
//                     if ((int)dojoList[i] < 0)
//                         {
//                             dojoList[i] = "Dojo";
//                         }
//                 }
//                 Console.Write("[ ");
//                     foreach (var obj in dojoList)
//                         {
//                             Console.Write(obj + " , ");
//                         }
//                 Console.WriteLine("]");
//             }
//         }
//     }
// }
