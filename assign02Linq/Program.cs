using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Text.RegularExpressions;
using static assign02Linq.ListGenerator;
using System.Diagnostics;
using System.ComponentModel;

namespace assign02Linq
{
    internal class Program

    {
        static void Main(string[] args)
        {

            #region LINQ - Aggregate Operators

            #region 1. Get the total units in stock for each product category.

            //var Result = ProductsList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, TotalUnitsInStock = c.Sum(u => u.UnitsInStock) });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, cheapestPrice = c.Min(u => u.UnitPrice) });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)

            //  var Result = from p in ProductsList
            //               group p by p.Category into CategoryGroup
            //               let MinPrice = CategoryGroup.Min(c => c.UnitPrice)         
            //               select new
            //               {
            //               Category = CategoryGroup.Key,                                 
            //               Products = CategoryGroup.Where(p => p.UnitPrice == MinPrice)
            //               };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 4. Get the most expensive price among each category's products.

            //var Result = ProductsList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, MostExpensivePrice = c.Max(u => u.UnitPrice) });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Get the products with the most expensive price in each category.
            //var Result = from p in ProductsList
            //             group p by p.Category into CategoryGroup
            //             let MaxPrice = CategoryGroup.Max(c => c.UnitPrice)
            //             select new
            //             {
            //                 Category = CategoryGroup.Key,
            //                 Products = CategoryGroup.Where(p => p.UnitPrice == MaxPrice)
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 6. Get the average price of each category's products.
            //var Result = ProductsList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, AveragePrice = c.Average(u => u.UnitPrice) });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ProductsList.Select(p => p.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = CustomersList.Select(c => c.CustomerName[0]).Union(ProductsList.Select(p => p.ProductName[0])).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result = CustomersList.Select(c => c.CustomerName[0]).Intersect(ProductsList.Select(p => p.ProductName[0])).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductsList.Select(c => c.ProductName[0]).Except(CustomersList.Select(p => p.CustomerName[0])).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductsList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //                         .Concat(CustomersList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(p => p.Region == "WA").SelectMany(o => o.Orders).Take(3);
            //foreach (var result in Result)
            //    Console.WriteLine(result);


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = CustomersList.Where(p => p.Region == "WA").SelectMany(o => o.Orders).Skip(2);
            //foreach (var result in Result)
            //    Console.WriteLine(result);


            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((num , i) => num > i);
            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 !=0 );
            //foreach (int item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((num , i) => num > i);   
            //foreach (int item in Result) 
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //bool Result = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(Result);     

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //if (ProductsList.Any(p => p.UnitsInStock == 0))
            //{
            //    var Result = ProductsList
            //    .Where(p => p.UnitsInStock == 0)
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Products = g.ToList() })
            //    .ToList();

            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine($"Category: {item.Category}");
            //        foreach (var product in item.Products)
            //        {
            //            Console.WriteLine($"Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //        }
            //    }
            //}
            //else Console.WriteLine("Don’t have");

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //if (ProductsList.All(p => p.UnitsInStock > 0))
            //{
            //var Result = ProductsList
            //.Where(p => p.UnitsInStock > 0)
            //.GroupBy(p => p.Category)
            //.Select(g => new { Category = g.Key, Products = g.ToList() })
            //.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}
            //}
            //else Console.WriteLine("False");


            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(n => n % 5 );
            //foreach (var g in Result)
            //{
            //    Console.WriteLine($"numbers with a reminder of {g.Key} when devided by 5 ");
            //      foreach (var num in g)
            //        Console.WriteLine(num);
            //}

            #endregion

            #region 2.Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");



            #endregion

            #region 3.Consider this Array as an Input , Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };



            #endregion

            #endregion


        }
    }
}
