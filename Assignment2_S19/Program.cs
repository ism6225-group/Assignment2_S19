using System;
using System.Collections.Generic;

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
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            //

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine(findMedian(arr2));
            //

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
        } // End of Main

        static void displayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
            Console.ReadKey(true);
        }



        //***//
        
        //**//
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
                Console.ReadKey(true);

            }
         catch
         {
         Console.WriteLine("error");
         }
        return new int []{ };
          }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            return 0;
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

    }
}
