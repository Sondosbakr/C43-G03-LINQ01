using System.Net.WebSockets;
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
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result = Arr.Select((name, index) => new { digit = index, length = name.Length })
                .Where(x => x.length < x.digit).Select(x => x.digit);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            #endregion
            #endregion



        }
    }
}
