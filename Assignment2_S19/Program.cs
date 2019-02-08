/*
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
                        foreach (int toy in prices)
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
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            return new int[] { };
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
                return QuickSort(array, left, right);
            }
        }

        /*
            An implementation of Quicksort Algorithm
        */
        private static int[] QuickSort(int[] array, int left, int right)
        {
            int iLeft = left;
            int iRight = right;
            //double pivotValue = left + ((right - left) / 2);
            //int pivot = array[Convert.ToInt32(pivotValue)];
            //Random rand = new Random();
            //int pivot = array[rand.Next(left, right)];
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
    }
}
