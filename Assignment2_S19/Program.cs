﻿/*
    Project  : Assignment 2 – Computational Problem Solving
    Coded by :
               Sameera - P1, P5, P6
               Vivek - P3, P7, P8
               Alhasan - P2, P4, Sort() Algorithm 
    Summary  : This C# Console application code is a group assignment
               that focuses tightly on problem solving and using basic sorting algorithms.
               It includes different methods:
                1. Left Rotation
                2. Maximum toys
                3. Balanced sums
                4. Missing numbers
                5. Grading students
                6. Find the median
                7. Closest numbers
                8. Day of Programmer
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Sort();
            //int[] prices2 = new int[10];
            //Random randNum = new Random();
            //for (int i = 0; i < prices2.Length; i++)
            //{
            //    prices2[i] = randNum.Next(-2, 2);
            //}
            //int[] sprices = Sort(prices2);
            //prices2[0] = 9;
            //displayArray(prices2);
            //displayArray(sprices);
            // 1. left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // 2. Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.ReadKey(true);

            // 3. Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadKey(true);

            // 4. Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // 5. grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // 6. find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            Console.WriteLine(findMedian(arr2));
            Console.ReadKey(true);

            // 7. closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // 8. Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey(true);
        } // End of Main

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey(true);
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
        //    int labels = new int[]a;
           try
         {
         int c;
        for (int i = 0; i < a.Length; i++)
         {
           c = (i + d) / a.Length;
                    //
                    // a[] labels;
                    // labels = new a[c];  
                    //new [] k = new int a[c];
                    //  Console.WriteLine(a[c]);
                  
                }
                
               // return c;
                //Console.ReadKey(true);

            }
         catch
         {
         Console.WriteLine("error");
         }
        return new int []{ };
          }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int budget)
        {
            int maximumToys = 0;
            int numberOfToys = 0;
            try
            {
                // If the number of priced toys is null or empty
                if (IsNullOrEmpty(prices))
                {
                    maximumToys = 0;
                }
                // If there is a toy with negative number as a price!
                else if (prices.Min() < 0)
                {
                    Console.WriteLine("There is at least one toy with negative (-) price!, please use reasonable prices");
                    maximumToys = 0;
                }
                // If the budget is not a negative number!
                else if (budget < 0)
                {
                    Console.WriteLine("Your budget is negative (-), please use reasonable budget");
                    maximumToys = 0;
                }
                // If maximumToys() got valid and reasonable parameters
                else
                {
                    numberOfToys = prices.Length;
                    // They are free toys, Mark will take them all :)
                    if (prices.Sum() == 0)
                    {
                        maximumToys = numberOfToys;
                    }
                    // If Mark has enough budget, he will take them all :)
                    else if (budget >= prices.Sum())
                    {
                        maximumToys = numberOfToys;
                    }
                    // If Mark does not have enough budget, he will take nothing all :(
                    else if (budget < prices.Min())
                    {
                        maximumToys = 0;
                    }
                    // If Mark has enough budget only for the minimum priced toy, he will take it :)
                    else if (budget == prices.Min())
                    {
                        maximumToys = 1;
                    }
                    /*
                        If Mark has only a certain amount to spend, and can take more than one toy
                        and he wants to maximize the number of toys he buys with this money
                    */
                    else
                    {
                        /*
                            1. Sort the prices array
                            2. Add more toys as long as Mark has enough budget
                            3. Break when Mark does not have enough budget
                        */
                        int[] sortedPrices = Sort(prices);
                        foreach (int toy in sortedPrices)
                        {
                            if (budget >= toy)
                            {
                                maximumToys++;
                                budget -= toy;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing maximumToys()");
            }
            return maximumToys;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] incompleteArray, int[] originalArray)
        {
            int[] missingNumber;
            try
            {
                // If the original array of numbers is null or empty
                if (IsNullOrEmpty(originalArray))
                {
                    missingNumber = null;
                }
                // If the incomplete array of numbers is null or empty
                else if (IsNullOrEmpty(incompleteArray))
                {
                    missingNumber = originalArray;
                }
                else
                {

                    //int[] sortedOriginalArray = Sort(originalArray);
                    //if (incompleteArray.Length == 1)
                    //{
                    //    int searchValue = Array.BinarySearch(myArr, myObject);
                    //    if (searchValue < 0)
                    //    {
                    //        Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
                    //    }
                    //    else
                    //    {
                            
                    //        Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
                    //    }
                    //}
                    //else
                    //{

                    //}
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing missingNumbers()");
            }
            //int[] distinctMissingNumbers = missingNumber.Distinct();
            //return distinctMissingNumbers;
            return new int[0];
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            int score = 0;
            int[] marks = new int[grades.Length];
            for(int i =0;i<grades.Length;i++)
            {
                score = ((grades[i] / 5) + 1) * 5;                          
                if (score - grades[i] < 3 && grades[i] > 37)            //checking the condition if lesser than 40 and meeting expectation

                    marks[i]= score;
                else
                {
                    marks[i] = grades[i];
                }
            }
            return marks;
            Console.ReadKey(true);
            //return 0;
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {


            try
            {

                int count = arr.Length;
                int temp = 0;             // Sorting the array

                for (int k1 = 0; k1 < arr.Length; k1++)
                {
                    for (int l = 0; l < arr.Length; l++)
                    {
                        if (arr[l] < arr[k1])
                        {
                            temp = arr[k1];
                            arr[k1] = arr[l];
                            arr[l] = temp;
                        }
                    }
                }
                
                // new []arr1 = new int arr[]{ };
                int medianValue = 0;



                if (count % 2 == 0)

                {

                    //if count is even
                    int no1 = arr[(count / 2) - 1];

                    int no2 = arr[(count / 2)];

                    medianValue = (no1 + no2) / 2;

                }

                else

                {

                    // if count is odd
                    medianValue = arr[(count / 2)];

                }
                //Double abc = Convert.ToDouble(medianValue);
                // return Convert.ToDouble(medianValue);

                return medianValue;

                Console.WriteLine("press any key");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("error");
            }
            return 0;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }

        // To skip sort in sum cases
        private static int[] Sort(int[] array)
        {
            if (IsNullOrEmpty(array))
            {
                return array;
            }
            else if (array.Min() == array.Max())
            {
                return array;
            }
            else
            {
                int left = 0;
                int right = (array.Length - 1);
                try
                {
                    int[] toSortArray = (int[])array.Clone();
                    return QuickSort(toSortArray, left, right);
                }
                catch
                {
                    Console.WriteLine("This is a huge array and consumes so much memory,\n" +
                        "Sort() will change the array itself without cloning!");
                    return QuickSort(array, left, right);
                }
            }
        }

        /*
            An implementation of Quicksort Algorithm
            Reference: https://en.wikipedia.org/wiki/Quicksort
        */
        private static int[] QuickSort(int[] array, int left, int right)
        {
            int iLeft = left;
            int iRight = right;
            int pivot = array[left];
            while (iLeft <= iRight)
            {
                while (array[iLeft] < pivot)
                {
                    iLeft++;
                }
                while (array[iRight] > pivot)
                {
                    iRight--;
                }
                if (iLeft <= iRight)
                {
                    int temp = array[iLeft];
                    array[iLeft] = array[iRight];
                    iLeft++;
                    array[iRight] = temp;
                    iRight--;
                }
            }
            if (left < iRight)
            {
                QuickSort(array, left, iRight);
            }
            if (iLeft < right)
            {
                QuickSort(array, iLeft, right);
            }
            return array;
        }

        private static bool IsNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("This is a null or empty array!");
                return true;
            }
            return false;
        }

        //private static int Frequency(int position, int[] array)
        //{
        //    int frequency = 0; // An integer to save the frequency value
        //    /*
        //        A for loop that:
        //        1) Starts from the position of the element to count
        //        2) Continues to count as long as the next element is equivalent
        //        3) Stop if it reached the last equivalent element
        //    */
        //    for (int i = position; i < array.Length && array[i] == array[position]; i++)
        //    {
        //        frequency++;
        //    }
        //    return frequency;
        //}
    }
}
