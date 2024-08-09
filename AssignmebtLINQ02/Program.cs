using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static AssignmebtLINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace AssignmebtLINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Element Operators

            #region 1. Get first Product out of Stock 

            //var firstOutOfStockProduct = productList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStockProduct?.ToString() ?? "No product out of stock");


            #endregion


            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var expensiveProduct = productList.FirstOrDefault(p => p.UnitPrice > 1000M);

            //Console.WriteLine(expensiveProduct?.ToString() ?? "No product with price > 1000");



            #endregion



            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(secondNumberGreaterThan5);



            #endregion



            //LINQ - Aggregate Operators


            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddCount = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine(oddCount);

            #endregion


            #region 3. Return a list of categories and how many products each has

            //var customerCounts = customerList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() }).ToList();
            //foreach (var customer in customerCounts)
            //{
            //    Console.WriteLine($"Customer: {customer.CustomerName}, Orders: {customer.OrderCount}");
            //}

            #endregion


            #region 4. Get the total of the numbers in an array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Sum();

            //Console.WriteLine(total);


            #endregion


            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalCharacter = words.SelectMany(w => w).Count();

            //Console.WriteLine(totalCharacter);

            #endregion


            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int WordLength = words.Min(w => w.Length);

            //Console.WriteLine(WordLength);

            #endregion


            #region  7. Longest word lengthint longestWordLength = words.Max(w => w.Length);
            // string[] words = File.ReadAllLines("dictionary_english.txt");
            //int longestWordLength = words.Max(w => w.Length);
            //Console.WriteLine(longestWordLength);
            #endregion


            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //double averageWordLength = words.Average(w => w.Length);
            //Console.WriteLine(averageWordLength);

            #endregion


            #region 9. Get the total units in stock for each product category.

            // var totalUnits = productList.GroupBy(p => p.Category).Select(g => new { CategoryId = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });

            #endregion


            #region 10. Get the cheapest price among each category's products

            //var cheapestPrice = productList
            // .GroupJoin(
            //     productList,
            //     c => c.Category,
            //     p => p.Category,
            //     (c, ps) => new { CategoryName = c.ProductName, CheapestPrice = ps.Min(p => p.UnitPrice) })
            // .ToList();

            //foreach (var category in cheapestPrice)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName}, Cheapest Price: {category.CheapestPrice}");
            //}
            #endregion



            #region  11.Get the products with the cheapest price in each category(Use Let)


            // var cheapestProductsPerCategory = productList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == g.Min(p => p.UnitPrice)) });

            #endregion

            #region 12. Get the most expensive price among each category's products.


            //var categoryProductCounts = productList
            // .GroupBy(p => p.Category)
            // .Select(g => new { CategoryID = g.Key, ProductCount = g.Count() })
            // .Join(
            //     productList,
            //     g => g.CategoryID,
            //     c => c.Category,
            //     (g, c) => new { c.ProductName, g.ProductCount }
            // )
            // .ToList();

            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"Category: {category.ProductName}, Products: {category.ProductCount}");
            //}

            #endregion


            #region 13. Get the products with the most expensive price in each category.

            // var mostExpensiveProducts = productList.GroupBy(p => p.Category).Select(g => new { CategoryID = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))})
            //.Join(
            //    productList, g => g.CategoryID,c => c.Category,(g, c) => new { c.ProductName, g.MostExpensiveProducts } ).ToList();

            // foreach (var category in mostExpensiveProducts)
            // {
            //     Console.WriteLine($"Category: {category.ProductName}");
            //     foreach (var product in category.MostExpensiveProducts)
            //     {
            //         Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //     }


            // }
            #endregion


            #region 14. Get the average price of each category's products.

            //var averagePricePerCategory = productList.GroupBy(p => p.Category).Select(g => new { CategoryID = g.Key, AveragePrice = g.Average(p => p.UnitPrice) })
            //      .Join( productList, g => g.CategoryID, c => c.Category,(g, c) => new { c.ProductName, g.AveragePrice }).ToList();

            //foreach (var category in averagePricePerCategory)
            //{
            //    Console.WriteLine($"Category: {category.ProductName}, Average Price: {category.AveragePrice}");
            //}
            #endregion



            //LINQ - Set Operators


            #region 1. Find the unique Category names from Product List

            //var uniqueCategoryNames = productList.Select(p => p.Category).Distinct();

            //foreach (var categoryName in uniqueCategoryNames)
            //{
            //    Console.WriteLine(categoryName);
            //}

            #endregion


            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var uniqueFirstLetter = productList.Select(p=> p.ProductName.FirstOrDefault()).Concat(customerList.Select(c => c.CustomerName.FirstOrDefault())).Distinct();

            //foreach (var letter in uniqueFirstLetter)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion


            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var commonFirstLetter = productList.Select(p => p.ProductName.FirstOrDefault()).Intersect(customerList.Select(c => c.CustomerName.FirstOrDefault()));

            //foreach (var letter in commonFirstLetter)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion


            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var productOnlyFirstLetter = productList.Select(p => p.ProductName.FirstOrDefault()).Except(customerList.Select(c => c.CustomerName.FirstOrDefault()));

            //foreach (var letter in productOnlyFirstLetter)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var lastThreeCharacter = productList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3))).Concat(customerList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));


            //foreach (var str in lastThreeCharacter)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion


            //LINQ - Partitioning Operators


            #region 1. Get the first 3 orders from customers in Washington

            //var first3OrdersFromWashington = customerList.Where(c => c.City== "Washington").SelectMany(c => c.Orders).Take(3);

            //foreach (var order in first3OrdersFromWashington)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}");
            //}


            #endregion


            #region 2. Get all but the first 2 orders from customers in Washington.


            var ordersExceptFirstTwo = customerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            //foreach (var order in ordersExceptFirstTwo)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}");
            //}

            #endregion


            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var elementsUntilLessThanPosition = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var number in elementsUntilLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsFromFirstDivisibleBy3 = numbers.SkipWhile(n => n % 3 != 0).Skip(1);

            //foreach (var number in elementsFromFirstDivisibleBy3)
            //{
            //    Console.WriteLine(number);
            //}



            #endregion


            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsFromFirstLessThanPosition = numbers.SkipWhile((n, index) => n >= index).Skip(1);
            //foreach (var number in elementsFromFirstLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion



            // LINQ - Quantifiers


            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //bool anyWordContainsEi = words.Any(word => word.Contains("ei"));

            //Console.WriteLine(anyWordContainsEi);





            #endregion


            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var categoriesWithOutOfStockProducts = productList.GroupBy(p => p.Category) .Where(g => g.Any(p => p.UnitsInStock == 0)).Select(g => new { CategoryI = g.Key, Products = g });

            //foreach (var group in categoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"Category: {group.CategoryI}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion


            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var categoriesWithAllInStockProducts = productList.GroupBy(p => p.Category)
            // .Where(g => g.All(p => p.UnitsInStock > 0))
            // .Select(g => new { CategoryId = g.Key, Products = g });

            //foreach (var group in categoriesWithAllInStockProducts)
            //{
            //    Console.WriteLine($"Category: {group.CategoryId}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion




            //LINQ – Grouping Operators


            #region 1.	Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedNumbers = numbers.GroupBy(n => n % 5);

            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            #endregion



            #region 2.	Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var groupedWords = words.GroupBy(word => word[0]);

            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            #endregion


            #region 3.	Consider this Array as an Input

            //string[] words = { "from", "salt", "earn", "last", "near", "form" };

            //var groupedWords = words.GroupBy(word => string.Concat(word.OrderBy(c => c)));

            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine("Group:");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            #endregion


        }
    }
}
