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
            var Result = ProductsList.Where(p => p.UnitsInStock >0);
            Result = from p in ProductsList
                     where p.UnitsInStock > 0
                     select p;
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion



        }
    }
}
