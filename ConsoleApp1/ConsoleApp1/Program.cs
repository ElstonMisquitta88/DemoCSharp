using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        /* LINQ Examples */

        // (1) Distinct Numbers
        var lst=new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 };
        var _dist = lst.Distinct();


        // (2) Filtering    
        var lst_filter = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var even = lst_filter.Where(x => x % 2 == 0);
        var odd = lst_filter.Where(x => x % 2 != 0);

        // (3) Sorting   
        var lst_sort = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var sor_asc = lst_sort.OrderBy(x => x);
        var sor_desc = lst_sort.OrderByDescending(x => x);


        // (4) First() and FirstOrDefault()


























        //ArrayList al = new ArrayList();

        //// Adding elements to the ArrayList
        //al.Add(1);
        //al.Add("sssss");
        //al.Add(3);


        //var nums = new[] { 1, 2, 3, 4 };
        //var sum = nums.Aggregate((a, b) => a + b);
        //Console.WriteLine(sum); // output: 10 (1+2+3+4)
        //Console.ReadLine();


        //string _val = "aaabbbceedddffffh";
        //char[] charArray = _val.ToCharArray();
        ////output 3a3b1c2e3d4f1h usign LINQ
        //var result = charArray.GroupBy(x => x).Select(x => x.Count() + x.Key.ToString()).Aggregate((x, y) => x + y);
        //Console.WriteLine(result);
        //Console.ReadLine();


        //StringBuilder sb = new StringBuilder();
        //int count = 1;
        //foreach (char c in charArray)
        //{
        //    sb.Append(c);
        //    if (charArray.Length > 1)
        //    {
        //        if (charArray[count] == c)
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            sb.Append(count);
        //            count = 1;
        //        }
        //    }
        //}


        //Write a C# program to reverse a string without using built-in functions.
        //string _val = "ABC";
        //char[] charArray = _val.ToCharArray();
        //int max = charArray.Length - 1;
        //StringBuilder sb = new StringBuilder();
        //for (int i = max; i >= 0; i--)
        //{
        //    sb.Append(charArray[i]);
        //}
        //Console.WriteLine(sb.ToString());

        //try
        //{
        //    int x = 10;
        //    int y = 0;
        //    int a = 10 / 0;
        //}
        //catch (DivideByZeroException exd)
        //{
        //    Console.WriteLine("dddd");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Finally block");
        //}

        //// write a function to find the second-largest number.
        //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //int max = arr[0];
        //int secondMax = arr[0];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > max)
        //    {
        //        secondMax = max;
        //        max = arr[i];
        //    }
        //    else if (arr[i] > secondMax)
        //    {
        //        secondMax = arr[i];
        //    }
        //}

        //Console.WriteLine(secondMax.ToString());


        //int[] arr = new int[5];
        ////for (int i = 0; i < arr.Length; i++)
        ////{
        ////    arr[i] = i;
        ////}
        ///
        //arr[0] = 1;
        //arr[1] = 3;
        //arr[2] = 5;
        //arr[3] = 6;
        //arr[4] = 8;

        //int val = BinarySearchTD(arr, 7);
        //Console.WriteLine(val);

        //double dbl = 102.22;
        //int i = dbl;
    }

    public List<T> AddElementsToList<T>()
    {
        List<T> reult = new List<T>();

        return reult;
    }
    public static int BinarySearchTD(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int value = nums[mid];


            Console.WriteLine("low: " + low + " high: " + high + " mid: " + mid + " value: " + value);

            if (value == target)
            {
                return mid;
            }
            else if (value < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }

        }

        return low;
    }
}