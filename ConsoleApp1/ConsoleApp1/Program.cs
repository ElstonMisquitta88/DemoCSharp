using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

public class User
{
    public string Name { get; set; } // Cannot be null
    public string? Nickname { get; set; } // Can be null
}

class Person // Reference type
{
    public string Name;
}

class Program
{
    //static void Main(string[] args)
    static async Task Main()
    {

        //var cts = new CancellationTokenSource();

        //var task = DoWorkAsync(cts.Token);

        //// Cancel after 2 seconds
        //cts.CancelAfter(2000);

        //try
        //{
        //    await task;
        //}
        //catch (OperationCanceledException)
        //{
        //    Console.WriteLine("Task was canceled!");
        //}

        //try
        //{
        //    int[] arr = new int[3];
        //    arr[5] = 10;  // Throws IndexOutOfRangeException
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Caught DivideByZeroException");
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine("Caught IndexOutOfRangeException");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Caught general Exception");
        //}
        //finally
        //{
        //    Console.WriteLine("Finally block always runs");
        //}



        //string str1 = "Hello1";
        //string str2 = "hello";
        //// Case-sensitive comparison
        //if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
        //{
        //    Console.WriteLine("Strings are equal ");
        //}
        //else
        //{
        //    Console.WriteLine("Strings are not equal ");
        //}




        //ArrayList al = new ArrayList();

        ////// Adding elements to the ArrayList
        //al.Add(1);
        //al.Add("sssss");
        //al.Add(3);


        //// Reference Type
        //Person person1 = new Person { Name = "John" };
        //Person person2 = person1; // COPY of reference (same object)
        ////person2.Name = "Alice";

        //Console.WriteLine($"person1.Name = {person1.Name}"); // Alice (changed)
        //Console.WriteLine($"person2.Name = {person2.Name}"); // Alice



        //// [+] Pagination
        //var products = Enumerable.Range(1, 20).Select(i => $"Product{i} ").ToList();
        //int pageSize = 5;

        //int _totalpage = products.Count / pageSize;
        //for (int i = 0; i < _totalpage; i++)
        //{
        //    int pageNumber = i; // We want page 2
        //    var paginatedProducts = products
        //    .Skip((pageNumber - 1) * pageSize)
        //    .Take(pageSize)
        //    .ToList();
        //    Console.WriteLine($"Page {pageNumber} items:");
        //    paginatedProducts.ForEach(Console.WriteLine);
        //}

        // [-] Pagination


        //[+] List.forEach

        //List<string> names = new List<string> { "Elston", "John", "Ravi" };
        //names.ForEach(name => Console.WriteLine(name));

        //Console.ReadLine();

        ////[-] List.forEach



        //Console.ReadLine();

        ////*******************************
        ////[+] Nullable Reference Types

        //string name = null; // ✅ Allowed — no warning or error

        //Console.WriteLine(name);
        //string name2 = null; // ❌ Not allowed — warning or error
        //Console.WriteLine(name2);
        //// Nullable reference types are enabled

        //string? name1 = null; //
        //Console.WriteLine(name1);

        ///* LINQ Examples */

        //// (1) Distinct Numbers
        //var lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 };
        //var _dist = lst.Distinct();


        //// (2) Filtering    
        //var lst_filter = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var even = lst_filter.Where(x => x % 2 == 0);
        //var odd = lst_filter.Where(x => x % 2 != 0);

        //// (3) Sorting   
        //var lst_sort = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var sor_asc = lst_sort.OrderBy(x => x);
        //var sor_desc = lst_sort.OrderByDescending(x => x);


        //// (4) First() and FirstOrDefault()
        //// Last and LastOrDefault()
        //var Listt = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var y = Listt.First();

        ////(5) Any() and All()
        //var Listt2 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var any = Listt2.Any(x => x % 2 == 0); // Any single element is even
        //var all = Listt2.All(x => x % 2 == 0); // All elements are even


        ////(6) Skip() and Take()
        //var Listt3 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var skip = Listt3.Skip(2).Take(3); // Skip 2 elements and take next 3 elements


        ////(7) zip
        //// The Zip operator merges the corresponding elements of two sequences using a specified selector function.
        //var letters = new string[] { "A", "B", "C", "D", "E" };
        //var numbers = new int[] { 1, 2, 3 };
        //var q = letters.Zip(numbers, (l, n) => l + n.ToString());


        ///*
        // * The Aggregate method is an accumulation function.
        // * An accumulation function combines the rows in a collection, 
        // * performs an operation on each one of them and returns a single value. 
        // */

        //// Aggregate
        //string _val = "aaabbbceedddffffh";   //Output 3a3b1c2e3d4f1h usign LINQ
        //char[] charArray = _val.ToCharArray();
        //var result = charArray.GroupBy(x => x).Select(x => x.Count() + x.Key.ToString()).Aggregate((x, y) => x + y);
        //var result2 = charArray.GroupBy(x => x).Select(x => x.Count() + x.Key.ToString()).Aggregate((x, y) => x + y);

        //// Aggregate
        //var nums = new[] { 1, 2, 3, 4 };
        //var sum = nums.Aggregate((a, b) => a + b);
        //Console.WriteLine(sum); // output: 10 (1+2+3+4)

        //// Single
        ////The single element of the input sequence that satisfies a condition.

        //string[] fruits = { "addbc", "pqdr", "mnc" };
        //string fruit2 = null;
        //try
        //{
        //    fruit2 = fruits.SingleOrDefault(fruit => fruit.Length == 3);
        //    Console.WriteLine(fruit2);
        //}
        //catch (System.InvalidOperationException)
        //{
        //    Console.WriteLine(@"The collection does not contain exactly
        //            one element whose length is greater than 3.");
        //}
        //Console.ReadLine();


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


    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"Working {i}...");
            await Task.Delay(1000, token); // also observes cancellation
        }
    }

    //public List<T> AddElementsToList<T>()
    //{
    //    List<T> reult = new List<T>();

    //    return reult;
    //}
    //public static int BinarySearchTD(int[] nums, int target)
    //{
    //    int low = 0;
    //    int high = nums.Length - 1;

    //    while (low <= high)
    //    {
    //        int mid = low + (high - low) / 2;
    //        int value = nums[mid];


    //        Console.WriteLine("low: " + low + " high: " + high + " mid: " + mid + " value: " + value);

    //        if (value == target)
    //        {
    //            return mid;
    //        }
    //        else if (value < target)
    //        {
    //            low = mid + 1;
    //        }
    //        else
    //        {
    //            high = mid - 1;
    //        }

    //    }

    //    return low;
    //}
}

