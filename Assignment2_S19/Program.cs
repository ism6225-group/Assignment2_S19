/*
    Project  : Assignment 2 – Computational Problem Solving
    Coded by :
               Sameera - P1, P5, P6 (Reviewed by Alhasan)
               Vivek - P3, P7, P8 (Reviewed by Alhasan)
               Alhasan - P2, P4, Sort() Algorithm (Reviewed by Sameera)
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
    Self Reflection:
        Sameera's Reflection:
                There were 8 codes 
                 * Issues faced: Testing corner cases
                 * Example: For Left Rotations, the value of rotations is negative
                 * The size of Array is extremely big !
                 * The entered values are beyond the given range
                 * They do not match either of the given condition
                 Resolution time: 3 seconds on every code
                 Successful : Yes
       Vivek's Reflection:
                * Learned how to solve corner cases like handling empty or null arrays
                * Got exposure to use of arrays in sorting methods
                * Got exposed to using predefined methods to solve problems saving time and reducing code length
                * Learned how to use comparison of two arrays
                * Learned how to sync,pull,push and work on group projects as a team using Github
        Alhasan's Reflection:
                1) Methods names and naming rule violation (The current assignment is an example of such violation)
                Methods names should start with Capital letters!
                2) Using System.Linq; simplified some problems 
                3) Bad implementation of quick sort could cause StackOverFlow!, fortunately I was able to solve it!
                4) Reviewing and building testcases is much harder than solving the problems! 

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
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));

        }

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] labels = new int[0];              //creating new array to store the values
            try
            {
                if (!IsNullOrEmpty(a))
                {
                    labels = new int[a.Length];
                    int count_of_rotation;
                    if (d < 0)
                    {
                        Console.WriteLine("The number of left rotations must be 0 or more!");
                        labels = a;
                    }
                    else if (d == 0)
                    {
                        labels = a;
                    }
                    else
                    {
                        for (int i = 0; i < a.Length; i++)
                        {
                            count_of_rotation = (i + d) % a.Length;
                            count_of_rotation = Math.Abs(count_of_rotation);
                            labels[i] = a[count_of_rotation];
                        }
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing rotLeft()");
            }
            return labels;         // return the rotated array
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
                    Console.WriteLine("There is a toy with negative (-) price!, please use reasonable prices\n" +
                        "(a positive number or 0 if it is free)");
                    maximumToys = 0;
                }
                // If the budget is not a negative number!
                else if (budget < 0)
                {
                    Console.WriteLine("Your budget is negative (-), please use reasonable budget\n" +
                        "(a positive number or 0 if mark has nothing)");
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
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
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
            try
            {
                if (!IsNullOrEmpty(arr))
                {
                    int n = arr.Count;

                    int[] Sample = arr.ToArray();
                    //total sum of given array
                    int ADDStorage = 0;
                    for (int x = 0; x < Sample.Length; x++)
                    {
                        ADDStorage = ADDStorage + Sample[x];

                    }

                    int[] Storage = new int[n];
                    Storage[0] = Sample[0];
                    for (int i = 1; i < n; i++)
                    {
                        Storage[i] = Storage[i - 1] + Sample[i];
                    }
                    bool test = false;
                    if (n == 1)
                        test = true;


                    int totalStorage = ADDStorage;
                    if (totalStorage > 0)
                    {
                        //comparing left and right array
                        for (int i = 1; i < n; i++)
                        {
                            int left_array = Storage[i - 1];
                            int right_array = Storage[n - 1] - Storage[i];
                            if (left_array == right_array)
                            {
                                test = true;
                                break;
                            }
                        }
                    }
                    else
                        test = true;
                    //checking for conditions where 1st position of array has a number and rest of the array is 0
                    for (int i = 0; i < n; i++)
                    {
                        if (totalStorage == Sample[i])
                        {
                            test = true;
                        }
                    }

                    if (test)
                    {
                        return "YES";
                    }
                    else
                        return "NO";
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing balancedSums()");
            }
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] incompleteArray, int[] originalArray)
        {
            int[] cleanMissingNumbers;
            try
            {
                // If the original array of numbers is null or empty
                if (IsNullOrEmpty(originalArray))
                {
                    Console.WriteLine("The original array of numbers must have at least one number!");
                    cleanMissingNumbers = Array.Empty<int>();
                }
                // If the incomplete array of numbers is null
                else if (incompleteArray == null)
                {
                    Console.WriteLine("This is a null array!\n" +
                        "The incomplete array of numbers must be at least Empty!");
                    cleanMissingNumbers = Array.Empty<int>();
                }
                // If the incomplete array of numbers has more numbers than the original array numbers!
                else if (incompleteArray.Length > originalArray.Length)
                {
                    Console.WriteLine("The array with missing numbers must not have numbers more than the original array numbers!");
                    cleanMissingNumbers = Array.Empty<int>();
                }
                // If the difference between maximum and minimum number in the original array is greater than 100.
                else if ((originalArray.Max() - originalArray.Min()) > 100)
                {
                    Console.WriteLine("The difference between maximum and minimum number in the original array must be less than or equal to 100.");
                    cleanMissingNumbers = Array.Empty<int>();
                }
                // If the incomplete array of numbers is empty, return all numbers
                else if (incompleteArray.Length == 0)
                {
                    int[] sortedOriginalArray = Sort(originalArray);
                    int[] distinctSortedOriginalArray = sortedOriginalArray.Distinct().ToArray();
                    cleanMissingNumbers = distinctSortedOriginalArray;
                }
                // If we need to sort to the incomplete array and the original array
                else
                {
                    int[] sortedOriginalArray = Sort(originalArray);
                    int[] sortedIncompleteArray = Sort(incompleteArray);
                    int[] distinctSortedOriginalArray = sortedOriginalArray.Distinct().ToArray();
                    int[] distinctSortedIncompleteArray = sortedIncompleteArray.Distinct().ToArray();
                    foreach (int number in distinctSortedIncompleteArray)
                    {
                        int searchIndex = Array.BinarySearch(distinctSortedOriginalArray, number);
                        if (searchIndex < 0)
                        {
                            Console.WriteLine("The array with missing numbers has a number not in the original array!\n" +
                                "It must not have that!");
                            cleanMissingNumbers = Array.Empty<int>();
                            return cleanMissingNumbers;
                        }
                    }
                    int numberOfMissingNumbers = originalArray.Length - incompleteArray.Length;
                    // If the incomplete array of numbers has same numbers as the original array!
                    if (numberOfMissingNumbers == 0)
                    {
                        if (sortedIncompleteArray.SequenceEqual(sortedOriginalArray))
                        {
                            cleanMissingNumbers = Array.Empty<int>();
                            Console.WriteLine("No missing numbers");
                        }
                        // If the incomplete array of numbers has number not in the original array!
                        else
                        {
                            Console.WriteLine("The array with missing numbers has either:\n" +
                                "* A number not in the original array!\n" +
                                "* A number with a frequency more than its frequency in the original array\n" +
                                "It must not have these!");
                            cleanMissingNumbers = Array.Empty<int>();
                        }
                    }
                    else
                    {
                        int[] missingNumbers = new int[numberOfMissingNumbers];
                        int missingNumbersIndex = 0;
                        foreach (int number in distinctSortedOriginalArray)
                        {
                            int searchIndex = Array.BinarySearch(distinctSortedIncompleteArray, number);
                            if (searchIndex < 0)
                            {
                                missingNumbers[missingNumbersIndex] = number;
                                missingNumbersIndex++;
                            }
                            else
                            {
                                int numberFrequencyInOriginalArray = sortedOriginalArray.Count(element => element == number);
                                int numberFrequencyInIncompleteArray = sortedIncompleteArray.Count(element => element == number);
                                if (numberFrequencyInOriginalArray > numberFrequencyInIncompleteArray)
                                {
                                    missingNumbers[missingNumbersIndex] = number;
                                    missingNumbersIndex++;
                                }
                                else if (numberFrequencyInOriginalArray < numberFrequencyInIncompleteArray)
                                {
                                    Console.WriteLine("The array with missing numbers has a number with a frequency more than its frequency in the original array\n" +
                                        "It must not have that!");
                                    cleanMissingNumbers = Array.Empty<int>();
                                    return cleanMissingNumbers;
                                }
                            }
                        }
                        cleanMissingNumbers = new int[missingNumbersIndex];
                        Array.Copy(missingNumbers, cleanMissingNumbers, cleanMissingNumbers.Length);
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
                cleanMissingNumbers = Array.Empty<int>();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing missingNumbers()");
                cleanMissingNumbers = Array.Empty<int>();
            }
            return cleanMissingNumbers;
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            int[] marks = new int[0];
            try
            {
                int score = 0;
                if (!IsNullOrEmpty(grades))
                {
                    marks = new int[grades.Length];         // creating new array to store marks
                    for (int i = 0; i < grades.Length; i++)
                    {
                        if (grades[i] < 0)                      // if entered marks are lesser than zero
                        {
                            Console.WriteLine("The grade entered {0} is less than 0, rounded to to 0", grades[i]);
                            continue;
                        }
                        else if (grades[i] > 100)               // if entered marks are greater than 100
                        {
                            Console.WriteLine("The grade entered {0} is greater than 100, rounded to to 0", grades[i]);
                            continue;
                        }
                        score = ((grades[i] / 5) + 1) * 5;
                        if (score - grades[i] < 3 && grades[i] > 37)            //checking the condition if lesser than 40 and meeting expectation
                            marks[i] = score;                       // store the scores
                        else
                        {
                            marks[i] = grades[i];
                        }
                    }
                }
                
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing gradingStudents()");
            }
            return marks;
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            try
            {
                int medianValue = 0;
                if (!IsNullOrEmpty(arr))
                {
                    int count = arr.Length;
                    int[] SortedArray = Sort(arr);  //using the sort method created below
                    if (count % 2 == 0)

                    {
                        //if count is even
                        int no1 = SortedArray[(count / 2) - 1];
                        int no2 = SortedArray[(count / 2)];
                        double medianValueDouble = (no1 + no2) / 2.0;
                        medianValue = Convert.ToInt32(medianValueDouble);
                        // If median is not integer, we show a message and return 0
                        if (medianValueDouble != medianValue)
                        {
                            Console.WriteLine("The Median is {0} and cannot return it because it is not integer!", medianValueDouble);
                            medianValue = 0;
                        }
                    }
                    else
                    {
                        // if count is odd
                        medianValue = SortedArray[(count / 2)];
                    }
                }
                return medianValue;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing findMedian()");
            }
            return 0;
        }

        static int[] closestNumbers(int[] arr)
        {
            int[] pairs = new int[0];
            try
            {
                if (!IsNullOrEmpty(arr))
                {
                    int[] Sorted = Sort(arr);

                    var pairsIndeces = new List<int>();
                    int min = Math.Abs(Sorted[1] - Sorted[0]);
                    int ComparedResult = min;
                    for (int i = 0, j = 1; j < arr.Length; i++, j++)
                    {
                        if ((ComparedResult = Math.Abs(Sorted[j] - Sorted[i])) <= min)
                        {

                            if (min != ComparedResult)
                                pairsIndeces.Clear();
                            pairsIndeces.Add(i);
                            pairsIndeces.Add(j);
                            min = ComparedResult;
                        }
                    }
                    pairs = new int[pairsIndeces.Count];
                    for (int i = 0; i < pairsIndeces.Count; i++)
                    {
                        pairs[i] = Sorted[pairsIndeces[i]];
                    }
                }

                return pairs;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing balancedSums()");
            }
            return pairs;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            try
            {
                if (year < 1700 || year > 2700)
                {
                    return "Please use a valid year from 1700 to 2700";
                }
                else if (year >= 1919)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        return "12.09." + year;
                    }
                    else
                        return "13.09." + year;
                }
                else if (year == 1918)
                {
                    return "26.09.1918";
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        return "12.09." + year;
                    }
                    else
                        return "13.09." + year;
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("This is a huge array and consumed so much memory!");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing dayOfProgrammer()");
            }
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

                catch (OutOfMemoryException)
                {
                    Console.WriteLine("This is a huge array and consumes so much memory,\n" +
                        "Sort() will change the array itself without cloning!");
                    return QuickSort(array, left, right);
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing Sort()");
                    return array;
                }
            }
        }

        /*
            An implementation of Quicksort Algorithm
            Reference: https://en.wikipedia.org/wiki/Quicksort
        */
        private static int[] QuickSort(int[] array, int left, int right)
        {
            try
            {
                int iLeft = left;
                int iRight = right;
                double pivotValue = left + ((right - left) / 2);
                int pivot = array[Convert.ToInt32(pivotValue)];
                //int pivot = array[left];
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
            catch
            {
                Console.WriteLine("Hold on, we will Sort using in BubbleSort Algorithm");
                return BubbleSort(array);
            }
        }
        /*
            An implementation of BubbleSort Algorithm used if Exception occured while computing QuickSort() 
            Source: https://github.com/ISM6225/Sort/blob/master/Sort/Program.cs
        */
        private static int[] BubbleSort(int[] bs_arr)
        {
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                    }
                }
            }
            return bs_arr;
        }

        // A method to check if array is Null Or Empty
        private static bool IsNullOrEmpty(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("This is a null or empty array!");
                return true;
            }
            return false;
        }

        // A method to check if List is Null Or Empty
        private static bool IsNullOrEmpty(List<int> array)
        {
            if (array == null || array.Count == 0)
            {
                Console.WriteLine("This is a null or empty array!");
                return true;
            }
            return false;
        }
    }
}
