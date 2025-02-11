using System.Net.WebSockets;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment01LINQ.ListGenerator;
namespace Assignment01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Result = ProductsList.Where(p => p.UnitsInStock >0);
            //Result = from p in ProductsList
            //         where p.UnitsInStock > 0
            //         select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //Result = from p in ProductsList
            //         where p.UnitsInStock > 0 && p.UnitPrice > 3
            //         select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Select((name, index) => new { digit = index, length = name.Length })
            //    .Where(x => x.length < x.digit).Select(x => x.digit);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result?.ProductName??"no match");
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(x => x > 5).Last();
            //Console.WriteLine(Result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(x => x % 2 == 1);
            //Result = (from x in Arr
            //          where x % 2 == 1
            //          select x).Count();
            //Console.WriteLine(Result);

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomersList.Select(c => new
            //{
            //    Id = c.CustomerID,
            //    Name = c.CustomerName,
            //    Order = c.Orders.Count()
            //});
            //Result = from c in CustomersList
            //         select new
            //         {
            //             Id = c.CustomerID,
            //             Name = c.CustomerName,
            //             Order = c.Orders.Count()
            //         };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Result = ProductsList.GroupBy(g => g.Category)
            //    .Select(p => new
            //    {
            //        Category = p.Key,
            //        ProductCount = p.Count()
            //    });

            //Result = from p in ProductsList
            //         group p by p.Category into g
            //         select new
            //         {
            //             Category = g.Key,
            //             ProductCount = g.Count()
            //         };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();
            //Result = (from s in Arr
            //         select s).Sum();
            //Console.WriteLine(Result);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Sum(word => word.Length);
            //Console.WriteLine(Result);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Min(x => x.Length);
            //Result = (from word in Words
            //         select word.Length).Min();
            //Console.WriteLine(Result);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Max(x => x.Length);
            //Result = (from word in Words
            //         select word.Length).Max();
            //Console.WriteLine(Result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var Result = Words.Average(x => x.Length);
            //Result = (from word in Words
            //         select word.Length).Average();
            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var Result = ProductsList.OrderBy(p => p.ProductName);
            //Result = from p in ProductsList
            //         orderby p.ProductName
            //         select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(word => word, new CaseInsensitiveComparer());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //Result = from p in ProductsList
            //         orderby p.UnitsInStock descending
            //         select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result = Arr.OrderBy(x => x.Length).ThenBy(x => x);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion



        }
    }
}
